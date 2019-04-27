using Microsoft.VisualStudio.TestTools.UnitTesting;
using SAS.Model;
using System.Linq;

namespace SAS.Web.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            using (var db = new SecurityAreaSystemContext())
            {
                var users           = db.Users.ToArray();
                var departments     = db.Departments.ToArray();
                var companies       = db.Companies.ToArray();
                var accessPoints    = db.AccessPoints.ToArray();
                var groups          = db.Groups.ToArray();
                var customers       = db.Customers.ToArray();
                var requests        = db.Requests.ToArray();
                var requestedGroups = db.RequestedGroups.ToArray();
                var requestedAccessPoints = db.RequestedAccessPoints.ToArray();
            }
        }
    }
}