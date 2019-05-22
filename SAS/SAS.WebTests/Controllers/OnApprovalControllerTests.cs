using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;
using SAS.Model.Abstract;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.Controllers;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SAS.WebTests.Controllers
{
    [TestClass]
    public class OnApprovalControllerTests : BaseControllerTests
    {
        [TestMethod]
        public void IndexTest()
        {
            // Arrange 
            var httpContext = new Mock<HttpContextBase>();
            var request = new Mock<HttpRequestBase>();
            var route = new RouteData();
            route.Values.Add("controller", "OnApproval");
            route.Values.Add("action", "Index");

            httpContext.SetupGet(_ => _.Request)
                .Returns(request.Object);

            var controller = Factory.Get<OnApprovalController>();
            controller.ControllerContext = new ControllerContext(httpContext.Object, route, controller);

            // Act
            var result = controller.Index();
            var model = result.Model;

            // Assert
            Assert.IsTrue(result.ViewName == "Index");
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.IsInstanceOfType(model, typeof(PageInfo));
        }

        [TestMethod]
        public void DetailsTest()
        {
            // Arrange
            var mockPrincipal = new Mock<IPrincipal>();

            var route = new RouteData();
            route.Values.Add("controller", "OnApproval");
            route.Values.Add("action", "DetailsTest");

            mockPrincipal.SetupGet(_ => _.Identity.Name).Returns(@"JTICORP\CSTARGYUHA");
            var mockContext = new Mock<ControllerContext>();
            mockContext.SetupGet(_ => _.HttpContext.User).Returns(mockPrincipal.Object);
            mockContext.SetupGet(_ => _.RouteData).Returns(route);

            var controller = Factory.Get<OnApprovalController>();
            controller.ControllerContext = mockContext.Object;

            var id = Factory.Get<IUnitOfWork>().Requests
                .ReadAll()
                .First(_ => _.Creator.Username.Equals(@"JTICORP\CSTARGYUHA", StringComparison.InvariantCultureIgnoreCase)).ID;

            // Act
            var result = controller.Details(id);
            var model = result;

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void RenderGridViewOnApprovalTest()
        {
            // Arrange 
            var mocks = new MockRepository(MockBehavior.Default);
            Mock<IPrincipal> mockPrincipal = mocks.Create<IPrincipal>();
            mockPrincipal.SetupGet(p => p.Identity.Name).Returns(@"JTICORP\CSTARGYUHA");

            var route = new RouteData();
            route.Values.Add("controller", "OnApproval");
            route.Values.Add("action", "RenderGridViewOnApproval");

            var mockContext = new Mock<ControllerContext>();
            mockContext.SetupGet(_ => _.RouteData).Returns(route);
            mockContext.SetupGet(_ => _.HttpContext.User).Returns(mockPrincipal.Object);

            IEnumerable<RequestViewModel> collection = null;

            var db = Factory.Get<IUnitOfWork>();

            var controller = Factory.Get<OnApprovalController>();
            controller.ControllerContext = mockContext.Object;

            // Act
            var result = controller.RenderGridViewOnApproval();
            var model = result.Model;

            // Assert
            Assert.IsNotNull(model);
            Assert.IsInstanceOfType(model, typeof(BusinessObjectCollectionViewModel<IRequest, RequestViewModel>));
            collection = (model as BusinessObjectCollectionViewModel<IRequest, RequestViewModel>).Model;

            Assert.IsTrue(collection.Count() != default(int));
        }
    }
}
