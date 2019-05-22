using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using System.Linq;
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

        public PartialViewResult RenderPartialGridViewAssignment()
        {
            var page = new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), "RenderPartialGridViewAssignment", Title);

            var data = (from request in DB.Requests.ReadAll()
                        where 
                        (request.ActiveStatus == ActiveStatus.Enabled
                        &&
                        request.State == EnumRequestState.OnLocationManager)
                        ||
                        (request.ActiveStatus == ActiveStatus.Enabled
                        &&
                        request.State == EnumRequestState.OnSecurityImplementation)
                        select request).ToArray();

            var vm = new BusinessObjectCollectionViewModel<IRequest, RequestViewModel>(page, data);

            return PartialView("/Views/AssignmentТoMe/PartialGridViewRequest.cshtml", vm);
        }

        public ActionResult Details(int? ID)
        {
            if(ID.HasValue)
            {
                var request = DB.Requests.ReadAll().SingleOrDefault(_ => _.ID == ID);
                if (request != null)
                {
                    switch(request.State)
                    {
                        case EnumRequestState.OnLocationManager:
                            return RedirectToActionPermanent("Index", "LocationManagerApproval", new { ID = ID });
                        case EnumRequestState.OnSecurityImplementation:
                            return RedirectToActionPermanent("Index", "SecurityImplementationApproval", new { ID = ID });
                        default: break;
                    }
                }
            }
            return RedirectToActionPermanent("Index");
        }
    }
}
