using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.BL.Abastract.Model_Builder;
using System.Linq;

namespace SAS.Web.BL.Factual.Model_Builder
{
    public class RequestedAccessPointBuilder : BaseModelBuilder<IRequestedAccessPoint>
    {
        public RequestedAccessPointBuilder(IUnitOfWork db, IRequestedGroup group, int id) : base(db)
        {
            Item.Group = group;

            Item.AccessPoint = db.AccessPoints.ReadAll().Single(_ => _.ID == id);
            Item.AccessPointStatus = RequestAccessPointStatus.OnApproval;
        }
    }
}