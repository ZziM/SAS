using Ninject;
using SAS.Model.Abstract;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.BL.Abastract.Request;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using SASModel = SAS.Model.Injection;
using SASWeb = SAS.Web.Helpers.Injection;

namespace SAS.Web.Controllers.Request
{
    public abstract class BaseRequestController : Controller
    {
        [Inject]
        public IRequestManager Manager { get; set; }
        [Inject]
        public IUnitOfWork DB { get; set; }

        protected IKernel Factory { get; private set; }
        protected BaseRequestController()
        {
            Factory = new StandardKernel(new SASModel.NinjectMapper(), new SASWeb.NinjectMapper());
        }

        public ActionResult RenderTextBoxCreator()
        {
            return PartialView("~/Views/Shared/Request/PartialTextBoxCreator.cshtml");
        }

        public ActionResult RenderGridViewGroup()
        {
            var page = new PageInfo("");
            var data = DB.Groups.ReadAll().ToArray();
            var businessModel = new BusinessObjectCollectionViewModel<IGroup, RequestGroupViewModel>(page, data);
            return PartialView("~/Views/Shared/Request/PartialGridViewRequestGroup.cshtml", businessModel);
        }

        public ActionResult RenderGridViewGroupDetail(int ID)
        {
            ViewData["ID"] = ID;
            var page = new PageInfo("");
            var data = DB.Groups.ReadAll().Single(_ => _.ID == ID).AccessPoints.ToArray();
            var businessModel = new BusinessObjectCollectionViewModel<IAccessPoint, RequestAccessPointViewModel>(page, data);
            return PartialView("~/Views/Shared/Request/PartialGridViewRequestGroupDetail.cshtml", businessModel);
        }
    }
}