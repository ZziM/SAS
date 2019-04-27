using SAS.Model.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class AccessPoint : DbObject, IAccessPoint
    {
        public string Name { get; set; }

        IQueryable<IEmployee> IAccessPoint.AccessPointManagers
        {
            get => AccessPointManagers.AsQueryable();
        }

        IQueryable<IGroup> IAccessPoint.Groups
        {
            get => Groups.AsQueryable();
        }

        #region EF
        public virtual ICollection<Employee> AccessPointManagers { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        #endregion
    }
}
