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
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SAS.WebTests.Controllers
{
    [TestClass]
    class OnApprovalControllerTests : BaseControllerTests
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
        }

        [TestMethod]
        public void DetailsTest(int ID)
        {
            // Arrange 
            var httpContext = new Mock<HttpContextBase>();
            var request = new Mock<HttpRequestBase>();
            var route = new RouteData();
            route.Values.Add("controller", "Details");
            route.Values.Add("action", "RenderGridViewOnApprovalTest");

            httpContext.SetupGet(_ => _.Request)
                .Returns(request.Object);

            var controller = Factory.Get<OnApprovalController>();
            controller.ControllerContext = new ControllerContext(httpContext.Object, route, controller);

            var id = Factory.Get<IUnitOfWork>().Requests.ReadAll().First().ID;
            // Act
            var result = controller.Details(id);
            var model = result.Model;

            // Assert
            //Assert.IsTrue(result.ViewName, "")
            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void RenderGridViewOnApprovalTest()
        {
            // Arrange 
            var httpContext = new Mock<HttpContextBase>();
            var request = new Mock<HttpRequestBase>();
            var route = new RouteData();
            route.Values.Add("controller", "OnApproval");
            route.Values.Add("action", "RenderGridViewOnApprovalTest");

            httpContext.SetupGet(_ => _.Request)
                .Returns(request.Object);

            var controller = Factory.Get<OnApprovalController>();
            controller.ControllerContext = new ControllerContext(httpContext.Object, route, controller);

            // Act
            var result = controller.RenderGridViewOnApproval();
            var model = result.Model;

            // Assert
            Assert.IsNotNull(model);
            Assert.IsInstanceOfType(model, typeof(BusinessObjectCollectionViewModel<IRequest, RequestViewModel>));
        }
    }
}
