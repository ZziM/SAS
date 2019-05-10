using Ninject;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Service.Helpers;
using System;

namespace SAS.Service
{
    public abstract class BaseService : IDisposable
    {
        private readonly IKernel Factory;
        protected IUnitOfWork DB { get; }
        protected BaseService()
        {
            Factory = new StandardKernel(new NinjectMapper());
            DB = Factory.Get<IUnitOfWork>();
        }

        public void Dispose()
        {
            
        }
    }
}
