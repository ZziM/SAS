using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAS.Web.Controllers.Request
{
    public class NewEmployeeController : Controller
    {
        // GET: RequestJTI
        public ActionResult Index()
        {
            return View("~/Views/Request/NewEmployee/Index.cshtml");
        }
    }
}