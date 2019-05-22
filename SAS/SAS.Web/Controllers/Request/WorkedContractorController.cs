using Ninject;
using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using System;
using Page = SAS.Web.Resources;
using System.Linq;
using System.Web.Mvc;
using SAS.Web.BL.Factual.Model_Builder;

namespace SAS.Web.Controllers.Request
{
    public class WorkedContractorController : BaseRequestController
    {
        public override string Title => Page.Pages.WorkedContractor;
        // GET: WorkedContractor
        public ActionResult Index()
        {
            return View("~/Views/Request/WorkedContractor/Index.cshtml", GeneratePageInfo());
        }

        public ActionResult RenderPartialComboBoxCustomer()
        {
            var data = DB.Contractors.ReadAll().ToArray();
            var vw = data.Select(_ => new ComboBoxEmployeeViewModel(_));
            return PartialView("~/Views/Request/WorkedEmployee/PartialComboBoxCustomer.cshtml", vw);
        }

        public ActionResult CreateRequest(RequestWorkedContractorViewModel model)
        {
            ICustomerContractor customer = default(ICustomerContractor);
            using (var builder = new CustomerContractorBuilder(DB, model))
            {
                customer = builder.Item;
            }

            IRequestContractor request = default(IRequestContractor);
            using (var builder = new RequestContractorBuilder(DB, customer, model, User.Identity))
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