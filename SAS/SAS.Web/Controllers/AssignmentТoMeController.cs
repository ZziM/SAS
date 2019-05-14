using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Page = SAS.Web.Resources;

namespace SAS.Web.Controllers
{
    public class AssignmentТoMeController : BaseController
    {
        public override string Title => Page.Pages.AssignmentToMe;
        public ViewResult Index()
        {
            return View("Index", GeneratePageInfo());
        }

        public PartialViewResult RenderPartialViewAssignment()
        {
            throw new NotImplementedException();
        }
    }
}
