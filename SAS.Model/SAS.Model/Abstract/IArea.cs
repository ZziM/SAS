using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model.Abstract
{
    public interface IArea : IDbObject
    {
        string Name { get; set; }
        IEnumerable<ILocation> Locations { get; set; }
    }
}
