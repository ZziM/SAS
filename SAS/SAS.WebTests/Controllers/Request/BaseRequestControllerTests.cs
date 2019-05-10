using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.WebTests.Controllers.Request
{
    [TestClass]
    public abstract class BaseRequestControllerTests
    {
        [TestMethod]
        public abstract void RenderTextBoxCreator();
        [TestMethod]
        public abstract void RenderGridViewGroup();
    }
}
