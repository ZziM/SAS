using Ninject.Modules;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Repository.UnitOfWork.Factual;
using SAS.Web.BL.Abastract.Request;
using SAS.Web.BL.Factual.Request;

namespace SAS.Web.Helpers.Injection
{
    public class NinjectMapper : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>();

            Bind<IRequestManager>().To<RequestManager>();
        }
    }
}