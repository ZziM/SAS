using System.Web.Mvc;
using Page = SAS.Web.Resources;

namespace SAS.Web.Controllers
{
    public class HomeController : BaseController
    {
        public override string Title => Page.Pages.Home;
        // GET: Home
        public ActionResult Index()
        {
            return View("Index", GeneratePageInfo());
        }
    }
}