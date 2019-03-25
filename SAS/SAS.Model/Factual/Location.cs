using SAS.Model.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class Location : DbObject, ILocation
    {
        public string Name { get; set; }

        IQueryable<IEmployee> ILocation.LocationManagers
        {
            get => LocationManagers.AsQueryable();
        }

        IQueryable<IGroup> ILocation.Areas
        {
            get => Areas.AsQueryable();
        }

        #region EF
        public virtual ICollection<Employee> LocationManagers { get; set; }

        public virtual ICollection<Group> Areas { get; set; }
        #endregion
    }
}
