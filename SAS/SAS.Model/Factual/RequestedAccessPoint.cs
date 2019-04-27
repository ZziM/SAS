using SAS.Model.Abstract;
using System;

namespace SAS.Model.Factual
{
    public class RequestedAccessPoint : IRequestedAccessPoint
    {
        public int ID { get; set; }

        IRequestedGroup IRequestedAccessPoint.Group
        {
            get => Group;
            set
            {
                if(value is RequestedGroup group)
                {
                    Group = group;
                    RequestedGroupID = group.ID;
                }
            }
        }

        IAccessPoint IRequestedAccessPoint.AccessPoint
        {
            get => AccessPoint;
            set
            {
                if(value is AccessPoint accessPoint)
                {
                    AccessPoint = accessPoint;
                    AccessPointID = accessPoint.ID;
                }
            }
        }

        public string AccessPointName { get; set; }
        public RequestAccessPointStatus AccessPointStatus { get; set; }

        public ActiveStatus ActiveStatus { get; set; }
        public DateTime DLM { get; set; }

        #region EF
        public int RequestedGroupID { get; set; }
        public virtual RequestedGroup Group { get; set; }
        public int AccessPointID { get; set; }
        public virtual AccessPoint AccessPoint { get; set; }
        #endregion
    }
}
