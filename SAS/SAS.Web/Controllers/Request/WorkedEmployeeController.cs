using Ninject;
using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.BL.Factual.Model_Builder;
using SAS.Web.BL.Factual.Request;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using Page = SAS.Web.Resources;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SAS.Web.Controllers.Request
{
    public class WorkedEmployeeController : BaseRequestController
    {
        public override string Title => Page.Pages.WorkedEmployee;

        public WorkedEmployeeController() : base()
        {

        }
        public ActionResult Index()
        {
            return View("~/Views/Request/WorkedEmployee/Index.cshtml", GeneratePageInfo());
        }

        public ActionResult RenderPartialComboBoxCustomer()
        {
            var data = DB.EmployeesJTI.ReadAll().ToArray();
            var vw = data.Select(_ => new ComboBoxEmployeeViewModel(_));
            return PartialView("~/Views/Request/WorkedEmployee/PartialComboBoxCustomer.cshtml", vw);
        }

        public ActionResult CreateRequest(RequestWorkedEmployeeViewModel model)
        {
            ICustomerJTI customer = default(ICustomerJTI);
            using (var builder = new CustomerJTIBuilder(DB, model))
            {
                customer = builder.Item;
            }

            IRequestJTI request = default(IRequestJTI);
            using (var builder = new RequestJTIBuilder(DB, customer, model, User.Identity))
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