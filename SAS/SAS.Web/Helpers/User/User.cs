using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Repository.UnitOfWork.Abstract;
using System;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SAS.Web.Helpers.User
{
    public class User
    {
        public IPrincipal Principal { get; }

        public User()
        {
            Principal = HttpContext.Current.User;
        }

        public IQueryable<IRequest> GetAssignmentToMe(IUnitOfWork db)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IRequest> GetOnApproval(IUnitOfWork db)
        {
            return from request in db.Requests.ReadAll()
                   where request.Creator.Username.Equals(Principal.Identity.Name, StringComparison.InvariantCultureIgnoreCase)
                   &&
                   request.ActiveStatus == ActiveStatus.Enabled
                   &&
                   request.State == EnumRequestState.OnLocationManager || request.State == EnumRequestState.OnSecurityImplementation
                   select request;
        }

        public IQueryable<IRequest> GetArchive(IUnitOfWork db)
        {
            return from request in db.Requests.ReadAll()
                   where request.Creator.Username.Equals(Principal.Identity.Name, StringComparison.InvariantCultureIgnoreCase)
                   &&
                   request.ActiveStatus == ActiveStatus.Enabled
                   && 
                   request.State == EnumRequestState.Archived
                   select request;
        }
    }
}