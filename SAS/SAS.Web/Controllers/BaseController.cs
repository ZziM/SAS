using Ninject;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.Helpers.User;
using SAS.Web.Models;
using System.Web.Mvc;
using SASModel = SAS.Model.Injection;
using SASWeb = SAS.Web.Helpers.Injection;

namespace SAS.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        [Inject]
        public IUnitOfWork DB { get; set; }
        protected IKernel Factory { get; private set; }
        public abstract string Title { get; }

        protected BaseController()
        {
            Factory = new StandardKernel(new SASModel.NinjectMapper(), new SASWeb.NinjectMapper());
        }

        public virtual PageInfo GeneratePageInfo()
        {
            return new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), ControllerContext.RequestContext.RouteData.Values["action"].ToString(), Title);
        }
    }
}