using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SAS.WebTests.Controllers.Request
{
    [TestClass]
    public abstract class BaseRequestControllerTests : BaseControllerTests
    {
        [TestMethod]
        public abstract void RenderTextBoxCreatorTest();
        [TestMethod]
        public abstract void RenderGridViewGroupTest();
    }
}
