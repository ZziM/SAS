using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.BL.Abastract.Model_Builder;
using SAS.Web.Models.Request;
using System;
using System.Linq;

namespace SAS.Web.BL.Factual.Model_Builder
{
    public class RequestJTIBuilder : BaseModelBuilder<IRequestJTI>
    {
        public RequestJTIBuilder(IUnitOfWork db, ICustomerJTI customer, RequestWorkedEmployeeViewModel model) : base(db)
        {
            Item.RequestAccess = RequestAccess.LocationManager;
            Item.RequestState = db.RequestStates.ReadAll().ToArray().Single(_ => _.State == EnumRequestState.OnLocationManager);
            Item.Creator = db.Employees.ReadAll().Single(_ => _.Username == model.Creator);
            Item.Customer = customer;
            Item.CreateDate = DateTime.Now;
            Item.StartAccessDate = model.StartAccessDate;
            Item.EndAccessDate = model.EndAccessDate;
            Item.AdditionalInformation = model.AdditionalInformation;
            Item.BusinessReason = model.BusinessReason;
        }
    }
}