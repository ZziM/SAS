using SAS.Model.Abstract;
using SAS.Web.Models;
using SAS.Web.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pages = SAS.Web.Resources.Pages;

namespace SAS.Web.Controllers
{
    public class LocationManagerApprovalController : BaseController
    {
        public override string Title => Pages.LocationManagerApproval;

        // GET: LocationManager
        public ActionResult Index(int? ID)
        {
            if (ID.HasValue)
            {
                var request = (from rqs in DB.Requests.ReadAll()
                               where rqs.Creator.Username.Equals(User.Identity.Name, StringComparison.InvariantCultureIgnoreCase)
                               &&
                               rqs.ID == ID.Value
                               select rqs).SingleOrDefault();

                var page = new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), "Index", $"{request} {Title}");
                var vw = new BusinessObjectViewModel<IRequest, RequestViewModel>(page, request);
                return View("Index", vw);
            }
            return RedirectToActionPermanent("Index", "AssignmentToMe");
        }

        public PartialViewResult RenderPartialGridViewGroup(int ID)
        {
            ViewData["RequestID"] = ID;
            var page = new PageInfo(ControllerContext.RequestContext.RouteData.Values["controller"].ToString(), "RenderPartialGridViewGroup", Title);
            var data = DB.RequestedGroups
                .ReadAll(_ => _.Request.ID == ID)
                .ToArray();

            var vw = new BusinessObjectCollectionViewModel<IRequestedGroup, RequestedGroupViewModel>(page, data);
            return PartialView("/Views/LocationManagerApproval/PartialGridViewGroup.cshtml", vw);
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

            return PartialView("/Views/LocationManagerApproval/PartialGridViewGroupDetail.cshtml", vw);
        }

        public ActionResult Approve(int ID)
        {
            throw new NotImplementedException();
        }

        public ActionResult Reject(int ID)
        {
            throw new NotImplementedException();
        }
    }
}