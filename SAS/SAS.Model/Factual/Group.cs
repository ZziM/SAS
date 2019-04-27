using SAS.Model.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class Group : DbObject, IGroup
    {
        public string Name { get; set; }
        public GroupType Type { get; set; }
        IQueryable<IAccessPoint> IGroup.AccessPoints
        {
            get => AccessPoints.AsQueryable();
        }

        #region EF
        public virtual ICollection<AccessPoint> AccessPoints { get; set; }
        #endregion
    }
}
