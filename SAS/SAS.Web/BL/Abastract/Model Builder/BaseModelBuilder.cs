using Ninject;
using SAS.Repository.UnitOfWork.Abstract;
using System;
using SASModel = SAS.Model.Injection;
using SASWeb = SAS.Web.Helpers.Injection;

namespace SAS.Web.BL.Abastract.Model_Builder
{
    public abstract class BaseModelBuilder<T> : IDisposable
    {
        public T Item { get; protected set; }
        protected readonly IKernel Factory;
        protected BaseModelBuilder(IUnitOfWork db)
        {
            var sasModelregistrations = new SASModel.NinjectMapper();
            var webRegistrations = new SASWeb.NinjectMapper();
            Factory = new StandardKernel(sasModelregistrations, webRegistrations);

            Item = Factory.Get<T>();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}