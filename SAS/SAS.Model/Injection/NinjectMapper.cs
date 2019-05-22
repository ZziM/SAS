using Ninject.Modules;
using SAS.Model.Abstract;
using SAS.Model.Factual;

namespace SAS.Model.Injection
{
    public class NinjectMapper : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerJTI>().To<CustomerJTI>();
            Bind<ICustomerVisitor>().To<CustomerVisitor>();
            Bind<IRequestVisitor>().To<RequestVisitor>();
            Bind<IRequestJTI>().To<RequestJTI>();
            Bind<IRequestedGroup>().To<RequestedGroup>();
            Bind<IRequestedAccessPoint>().To<RequestedAccessPoint>();
        }
    }
}
