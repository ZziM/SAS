using SAS.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class RequestedGroup : IRequestedGroup
    {
        public int ID { get; set; }
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

        IQueryable<IRequestedAccessPoint> IRequestedGroup.AccessPoints
        {
            get
            {
                return AccessPoints.AsQueryable();
            }
        }

        IGroup IRequestedGroup.Group
        {
            get => Group;
            set
            {
                if(value is Group group)
                {
                    Group = group;
                }
            }
        }

        public ActiveStatus ActiveStatus { get; set; }

        public DateTime DLM { get; set; }

        #region EF
        public int RequestID { get; set; }
        public virtual Request Request { get; set; }
        public virtual ICollection<RequestedAccessPoint> AccessPoints { get; set; }
        public RequestGroupStatus GroupStatus { get; set; }
        public int GroupID { get; set; }
        public virtual Group Group { get; set; }
        #endregion

        public RequestedGroup()
        {
            AccessPoints = new HashSet<RequestedAccessPoint>();
        }
    }
}
