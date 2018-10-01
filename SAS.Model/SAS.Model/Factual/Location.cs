using SAS.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model.Factual
{
    public class Location : DbObject, ILocation
    {
        public string Name { get; set; }

        IEnumerable<IEmployee> ILocation.LocationManagers
        {
            get => LocationManagers;
            set
            {
                if (value is IEnumerable<Employee> locationManagers)
                    LocationManagers = locationManagers.ToList();
            }
        }

        IEnumerable<IArea> ILocation.Areas
        {
            get => Areas;
            set
            {
                if (value is IEnumerable<Area> areas)
                    Areas = areas.ToList();
            }
        }

        #region EF
        public virtual ICollection<Employee> LocationManagers { get; set; }

        public virtual ICollection<Area> Areas { get; set; }
        #endregion
    }
}
