using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.BL.Abastract.Model_Builder;
using SAS.Web.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SAS.Web.BL.Factual.Model_Builder
{
    public class RequestContractorBuilder : BaseModelBuilder<IRequestContractor>
    {
        public RequestContractorBuilder(IUnitOfWork db, ICustomerContractor customer, RequestWorkedContractorViewModel model, IIdentity identity) : base(db)
        {
            Item.RequestAccess = RequestAccess.LocationManager;
            Item.State = EnumRequestState.OnLocationManager;
            Item.ActiveStatus = ActiveStatus.Enabled;
            Item.Creator = db.Employees.ReadAll().Single(_ => _.Username == identity.Name);
            Item.Customer = customer;
            Item.CreateDate = DateTime.Now;
            Item.StartAccessDate = model.StartAccessDate;
            Item.EndAccessDate = model.EndAccessDate;
            Item.AdditionalInformation = model.AdditionalInformation;
            Item.BusinessReason = model.BusinessReason;
        }
    }
}