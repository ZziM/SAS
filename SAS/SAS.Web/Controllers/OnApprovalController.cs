using Ninject;
using SAS.Model.Abstract;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using System;
using Page = SAS.Web.Resources;
using System.Linq;
using System.Web.Mvc;

namespace SAS.Web.Controllers
{
    public class OnApprovalController : BaseController
    {
        public override string Title => Page.Pages.OnApproval;

        [Inject]
        public IUnitOfWork DB { get; set; }
        // GET: OnApproval
        public ViewResult Index()
        {
            return View("Index", GeneratePageInfo());
            var data = DB.Requests.ReadAll()
                .Where(request => request.Groups
                .Any(group => group.AccessPoints
                .Any(requestAccessPoint => requestAccessPoint.AccessPoint.AccessPointManagers
                .Any(accessPoint => true))))
                .ToArray();
        }

        public ViewResult Details(int ID)
        {
            return View();
        }

        public PartialViewResult RenderGridViewOnApproval()
        {
            var page = new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), "RenderGridViewOnApproval", Title); 
            var data = DB.Requests.ReadAll().ToArray();
            var vw = new BusinessObjectCollectionViewModel<IRequest, RequestViewModel>(page, data);
            return PartialView("/Views/OnApproval/PartialGridViewOnApproval.cshtml", vw);
        }
    }
}