using Ninject;
using SAS.Repository.UnitOfWork.Abstract;
using System.Linq;
using System.Web.Mvc;

namespace SAS.Web.Controllers
{
    public class OnApprovalController : Controller
    {
        [Inject]
        public IUnitOfWork DB { get; set; }
        // GET: OnApproval
        public ActionResult Index()
        {
            var requests = DB.RequestedGroups.ReadAll().Where(_ => _.AccessPoints.Any(_ => _.))
            return View();
        }
    }
}