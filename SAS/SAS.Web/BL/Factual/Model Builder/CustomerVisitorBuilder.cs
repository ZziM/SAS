using SAS.Model.Abstract;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.BL.Abastract.Model_Builder;
using SAS.Web.Models.Request;

namespace SAS.Web.BL.Factual.Model_Builder
{
    public class CustomerVisitorBuilder : BaseModelBuilder<ICustomerVisitor>
    {
        public CustomerVisitorBuilder(IUnitOfWork db, RequestVisitorViewModel model) : base(db)
        {
            Item.FirstName = model.FirstName;
            Item.MiddleName = model.MiddleName;
            Item.LastName = model.LastName;
        }
    }
}