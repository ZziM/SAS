using Ninject;
using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SAS.Web.Controllers.Request
{
    public class WorkedContractorController : BaseRequestController
    {
        // GET: WorkedContractor
        public ActionResult Index()
        {
            return View("~/Views/Request/WorkedContractor/Index.cshtml");
        }

        public ActionResult RenderPartialComboBoxCustomer()
        {
            var data = DB.Contractors.ReadAll().ToArray();
            var vw = data.Select(_ => new ComboBoxEmployeeViewModel(_));
            return PartialView("~/Views/Request/WorkedEmployee/PartialComboBoxCustomer.cshtml", vw);
        }

        public ActionResult CreateRequest(RequestWorkedContractorViewModel model)
        {
            //var request = Factory.Get<IRequestContractor>();
            //request.RequestAccess = RequestAccess.OnLocationManager;
            //var customer = Factory.Get<ICustomerContractor>();

            //var customerEmployee = DB.Contractors.ReadAll()
            //  .Single(_ => _.ID == model.CustomerID);

            //customer.FirstName = customerEmployee.FirstName;
            //customer.MiddleName = customerEmployee.MiddleName;
            //customer.LastName = customerEmployee.LastName;
            //customer.SAPNumber = customerEmployee.SAPNumber;
            //customer.Username = customerEmployee.Username;
            //customer.Department = customerEmployee.Department.Name;
            //customer.Company = customerEmployee.Company.Name;

            //var creator = DB.Employees.ReadAll()
            // .Single(_ => _.Username == model.Creator);

            //request.Creator = creator;
            //request.Customer = customer;

            //request.CreateDate = DateTime.Now;
            //request.StartAccessDate = model.StartAccessDate;
            //request.EndAccessDate = model.EndAccessDate;
            //request.AdditionalInformation = model.AdditionalInformation;
            //request.BusinessReason = model.BusinessReason;

            //DB.Requests.Create(request);

            //foreach (var itemID in model.RequestedItemsID)
            //{
            //    var groupInformation = DB.Groups.ReadAll().Single(_ => _.ID == itemID);

            //    var requestGroup = Factory.Get<IRequestedGroup>();
            //    requestGroup.Request = request;

            //    requestGroup.GroupName = groupInformation.Name;
            //    requestGroup.GroupStatus = RequestGroupStatus.OnApproval;
            //    DB.RequestedGroups.Create(requestGroup);

            //    foreach (var accessPoint in groupInformation.AccessPoints)
            //    {
            //        var accessPointInformation = DB.AccessPoints.ReadAll().Single(_ => _.ID == accessPoint.ID);

            //        var requestAccessPoint = Factory.Get<IRequestedAccessPoint>();
            //        requestAccessPoint.Group = requestGroup;

            //        requestAccessPoint.AccessPointName = accessPointInformation.Name;
            //        requestAccessPoint.AccessPointStatus = RequestAccessPointStatus.OnApproval;

            //        DB.RequestedAccessPoints.Create(requestAccessPoint);
            //    }
            //}

            //DB.Save();

            return RedirectToAction("Index");
        }
    }
} 