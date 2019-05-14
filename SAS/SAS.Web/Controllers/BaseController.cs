using SAS.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAS.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public abstract string Title { get; }
        public virtual PageInfo GeneratePageInfo()
        {
            return new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), ControllerContext.RequestContext.RouteData.Values["action"].ToString(), Title);
        }
    }
}