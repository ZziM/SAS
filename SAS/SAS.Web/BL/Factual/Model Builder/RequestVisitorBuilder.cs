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
    public class RequestVisitorBuilder : BaseModelBuilder<IRequestVisitor>
    {
        public RequestVisitorBuilder(IUnitOfWork db, ICustomerVisitor customer, RequestVisitorViewModel model, IIdentity identity) : base(db)
        {
            Item.RequestAccess = RequestAccess.LocationManager;
            Item.State = EnumRequestState.OnLocationManager;
            Item.ActiveStatus = ActiveStatus.Enabled;
            Item.Creator = db.Employees.ReadAll().Single(_ => _.Username == identity.Name);
            Item.Customer = customer;
            Item.CreateDate = DateTime.Now;
            Item.StartAccessDate = model.StartAccessDate.Value;
            Item.EndAccessDate = model.EndAccessDate.Value;
            Item.AdditionalInformation = model.AdditionalInformation;
            Item.BusinessReason = model.BusinessReason;
        }
    }
}