using SAS.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class RequestedGroup : IRequestedGroup
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        IRequest IRequestedGroup.Request
        {
            get
            {
                return Request;
            }
            set
            {
                if (value is Request request)
                {
                    Request = request;
                    RequestID = request.ID;
                }
            }
        }

        IGroup IRequestedGroup.Group
        {
            get
            {
                return Group;
            }
            set
            {
                if (value is Group group)
                {
                    Group = group;
                    GroupID = group.ID;
                }
            }
        }

        IQueryable<IRequestedAccessPoint> IRequestedGroup.AccessPoints
        {
            get => AccessPoints.AsQueryable();
        }

        public ActiveStatus ActiveStatus { get; set; }

        public DateTime DLM { get; set; }

        #region EF
        public int? GroupID { get; set; }
        public virtual Group Group { get; set; }
        public int RequestID { get; set; }
        public virtual Request Request { get; set; }
        public virtual ICollection<RequestedAccessPoint> AccessPoints { get; set; }
        public RequestGroupStatus GroupStatus { get; set; }
        #endregion
    }
}
