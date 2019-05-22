using Ninject;
using SAS.Model.Abstract;
using SAS.Web.BL.Abastract.Request;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using System.Linq;
using System.Web.Mvc;

namespace SAS.Web.Controllers.Request
{
    public abstract class BaseRequestController : BaseController
    {
        [Inject]
        public IRequestManager Manager { get; set; }
        protected BaseRequestController() : base()
        {
            
        }

        public ActionResult RenderTextBoxCreator()
        {
            return PartialView("~/Views/Shared/Request/PartialTextBoxCreator.cshtml");
        }

        public ActionResult RenderGridViewGroup()
        {
            var page = GeneratePageInfo();
            var data = DB.Groups.ReadAll().ToArray();
            var businessModel = new BusinessObjectCollectionViewModel<IGroup, RequestGroupViewModel>(page, data);
            return PartialView("~/Views/Shared/Request/PartialGridViewRequestGroup.cshtml", businessModel);
        }

        public ActionResult RenderGridViewGroupDetail(int ID)
        {
            ViewData["ID"] = ID;
            var page = GeneratePageInfo();
            var data = DB.Groups.ReadAll().Single(_ => _.ID == ID).AccessPoints.ToArray();
            var businessModel = new BusinessObjectCollectionViewModel<IAccessPoint, RequestAccessPointViewModel>(page, data);
            return PartialView("~/Views/Shared/Request/PartialGridViewRequestGroupDetail.cshtml", businessModel);
        }
    }
}