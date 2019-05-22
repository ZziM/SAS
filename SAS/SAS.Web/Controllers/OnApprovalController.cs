using Ninject;
using SAS.Model.Abstract;
using SAS.Repository.UnitOfWork.Abstract;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using System;
using Page = SAS.Web.Resources;
using System.Linq;
using System.Web.Mvc;
using SAS.Model.Factual;

namespace SAS.Web.Controllers
{
    public class OnApprovalController : BaseController
    {
        public override string Title => Page.Pages.OnApproval;

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

        public ActionResult Details(int? ID)
        {
            if(ID.HasValue)
            {
                var request = (from rqs in DB.Requests.ReadAll()
                               where rqs.Creator.Username.Equals(User.Identity.Name, StringComparison.InvariantCultureIgnoreCase)
                               &&
                               rqs.ID == ID.Value
                               select rqs).SingleOrDefault();

                var page = new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), "Details", Title);
                var vw = new BusinessObjectViewModel<IRequest, RequestViewModel>(page, request);
                return View("Details", vw);
            }
            return RedirectToAction("Index");
        }

        public PartialViewResult RenderPartialGridViewGroup(int? ID)
        {
            ViewData["RequestID"] = ID;
            var page = new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), "RenderPartialGridViewGroup", Title);
            var data = DB.RequestedGroups
                .ReadAll(_ => _.Request.ID == ID.Value)
                .ToArray();

            var vw = new BusinessObjectCollectionViewModel<IRequestedGroup, RequestedGroupViewModel>(page, data);
            return PartialView("/Views/OnApproval/PartialGridViewGroup.cshtml", vw);
        }

        public PartialViewResult RenderGridViewRequestGroupDetail(int requestID, int groupID)
        {
            ViewData["RequestID"] = requestID;
            ViewData["GroupID"] = groupID;
            var page = new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), "RenderGridViewRequestGroupDetail", Title);

            var data = DB.RequestedGroups
                .ReadAll().Single(_ => _.Request.ID == requestID && _.Group.ID == groupID)
                .AccessPoints.ToArray();

            var vw = new BusinessObjectCollectionViewModel<IRequestedAccessPoint, RequestedAccessPointViewModel>(page, data);

            return PartialView("/Views/OnApproval/PartialGridViewGroupDetail.cshtml", vw);
        }

        public PartialViewResult RenderGridViewOnApproval()
        {
            var page = new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), "RenderGridViewOnApproval", Title);

            var data = (from request in DB.Requests.ReadAll()
                        where request.Creator.Username.Equals(User.Identity.Name, StringComparison.InvariantCultureIgnoreCase)
                        &&
                        request.ActiveStatus == ActiveStatus.Enabled
                        &&
                        request.State == EnumRequestState.OnLocationManager || request.State == EnumRequestState.OnSecurityImplementation
                        select request).ToArray();

            var vw = new BusinessObjectCollectionViewModel<IRequest, RequestViewModel>(page, data);
            return PartialView("/Views/OnApproval/PartialGridViewRequest.cshtml", vw);
        }
    }
}