using SAS.Model.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class Area : DbObject, IArea
    {
        public string Name { get; set; }
        IEnumerable<ILocation> IArea.Locations
        {
            get => Locations;
            set
            {
                if (value is IEnumerable<Location> locations)
                {
                    Locations = locations.ToList();
                }
            }
        }

        #region EF
        public virtual ICollection<Location> Locations { get; set; }
        #endregion
    }
}
