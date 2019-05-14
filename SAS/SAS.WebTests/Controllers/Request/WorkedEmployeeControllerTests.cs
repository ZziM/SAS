using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.Controllers.Request;
using SAS.Web.Helpers.Injection;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using SAS.WebTests.Controllers.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SAS.Web.Controllers.Request.Tests
{
    [TestClass]
    public class WorkedEmployeeControllerTests : BaseRequestControllerTests
    {
        [TestMethod]
        public void IndexTest()
        {

        }

        [TestMethod()]
        public void RenderPartialComboBoxCustomerTest()
        {
            // Arrange
            var controller = Factory.Get<WorkedEmployeeController>();
            //Act
            var viewResult = controller.RenderPartialComboBoxCustomer() as PartialViewResult;
            //Assert
            Assert.IsNotNull(viewResult);
            Assert.IsInstanceOfType(viewResult.Model, typeof(IEnumerable<ComboBoxEmployeeViewModel>));
            Assert.IsTrue(string.Equals(viewResult.ViewName, "~/Views/Request/WorkedEmployee/PartialComboBoxCustomer.cshtml", StringComparison.InvariantCultureIgnoreCase));

        }

        [TestMethod()]
        public override void RenderTextBoxCreatorTest()
        {
            // Arrange
            var db = Factory.Get<IUnitOfWork>();
            var controller = Factory.Get<WorkedEmployeeController>();
            //Act
            var viewResult = controller.RenderTextBoxCreator() as PartialViewResult;
            //Assert
            Assert.IsNotNull(viewResult);
            Assert.IsTrue(string.Equals(viewResult.ViewName, "~/Views/Shared/Request/PartialTextBoxCreator.cshtml", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public override void RenderGridViewGroupTest()
        {
            // Arrange
            var context = new Mock<HttpContextBase>();
            var request = new Mock<HttpRequestBase>();
            context
                .Setup(c => c.Request)
                .Returns(request.Object);
            var route = new RouteData();
            route.Values.Add("controller", "WorkedEmployee");
            route.Values.Add("action", "RenderGridViewGroup");

            var db = Factory.Get<IUnitOfWork>();
            var controller = Factory.Get<WorkedEmployeeController>();
            controller.ControllerContext = new ControllerContext(context.Object, route, controller);

            //Act
            var viewResult = controller.RenderGridViewGroup() as PartialViewResult;
            //Assert
            Assert.IsNotNull(viewResult);
            Assert.IsInstanceOfType(viewResult.Model, typeof(BusinessObjectCollectionViewModel<RequestGroupViewModel>));
            Assert.IsTrue(string.Equals(viewResult.ViewName, "~/Views/Shared/Request/PartialGridViewRequestGroup.cshtml", StringComparison.InvariantCultureIgnoreCase));
        }
        [TestMethod]
        public void CreateRequest()
        {
            //Arrange
            var db = Factory.Get<IUnitOfWork>();
            RequestWorkedEmployeeViewModel model = new RequestWorkedEmployeeViewModel
            {
                Creator = db.Employees.ReadAll().First().Username,
                CustomerID = db.EmployeesJTI.ReadAll().First().ID,
                StartAccessDate = DateTime.Now,
                RequestedItemsID = new[] 
                { 
                    1
                },
                EndAccessDate = null,
                AdditionalInformation = "I don't know what I should say =(",
                BusinessReason = "Just for fun =)"
            };
            var controller = Factory.Get<WorkedEmployeeController>();
            //Act
            var viewResult = controller.CreateRequest(model);
            //Assert
        }
    }
}