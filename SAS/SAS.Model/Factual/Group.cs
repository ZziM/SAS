using SAS.Model.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class Group : DbObject, IGroup
    {
        public string Name { get; set; }
        public GroupType Type { get; set; }
        IQueryable<ILocation> IGroup.Locations
        {
            get => Locations.AsQueryable();
        }

        #region EF
        public virtual ICollection<Location> Locations { get; set; }
        #endregion
    }
}
