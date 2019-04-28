using Ninject.Modules;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Repository.UnitOfWork.Factual;

namespace SAS.Web.Helpers.Injection
{
    public class NinjectMapper : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>();
        }
    }
}