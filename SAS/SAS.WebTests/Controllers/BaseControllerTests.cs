using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using ModelNinject = SAS.Model.Injection;
using WebNinject = SAS.Web.Helpers.Injection;

namespace SAS.WebTests.Controllers
{
    public class BaseControllerTests
    {
        protected IKernel Factory { get; set; }

        [TestInitialize]
        public void Setup()
        {
            Factory = new StandardKernel(new ModelNinject.NinjectMapper(), new WebNinject.NinjectMapper());
        }
    }
}
