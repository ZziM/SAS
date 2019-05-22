using SAS.Model.Abstract;
using SAS.Web.BL.Factual.Model_Builder;
using SAS.Web.Models.Request;
using System;
using System.Linq;
using System.Web.Mvc;
using Page = SAS.Web.Resources;

namespace SAS.Web.Controllers.Request
{
    public class VisitorController : BaseRequestController
    {
        public override string Title => Page.Pages.Visitor;

        public VisitorController()
        {

        }

        public ActionResult Index()
        {
            return View("~/Views/Request/Visitor/Index.cshtml", GeneratePageInfo());
        }

        public ActionResult CreateRequest(RequestVisitorViewModel model)
        {
            ICustomerVisitor customer = default(ICustomerVisitor);
            using (var builder = new CustomerVisitorBuilder(DB, model))
            {
                customer = builder.Item;
            }

            IRequestVisitor request = default(IRequestVisitor);
            using (var builder = new RequestVisitorBuilder(DB, customer, model, User.Identity))
            {
                request = builder.Item;
                DB.Requests.Create(request);
            }

            foreach (var itemID in model.RequestedItemsID)
            {
                IRequestedGroup group = default(IRequestedGroup);
                using (var builder = new RequestedGroupBuilder(DB, request, itemID))
                {
                    group = builder.Item;
                    DB.RequestedGroups.Create(group);
                }

                foreach (var item in DB.Groups.ReadAll().Single(_ => _.ID == itemID).AccessPoints)
                {
                    IRequestedAccessPoint accessPoint = default(IRequestedAccessPoint);
                    using (var builder = new RequestedAccessPointBuilder(DB, group, item.ID))
                    {
                        accessPoint = builder.Item;
                        DB.RequestedAccessPoints.Create(accessPoint);
                    }
                }
            }

            DB.Save();

            return RedirectToAction("Index");
        }
    }
}