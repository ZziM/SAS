using SAS.Model.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class Group : DbObject, IGroup
    {
        public string Name { get; set; }
        public GroupType Type { get; set; }
        IEnumerable<ILocation> IGroup.Locations
        {
            get => Locations;
            set
            {
                if (value is IEnumerable<Location> locations)
                    Locations = locations.ToList();
            }
        }

        #region EF
        public virtual ICollection<Location> Locations { get; set; }
        #endregion
    }
}
