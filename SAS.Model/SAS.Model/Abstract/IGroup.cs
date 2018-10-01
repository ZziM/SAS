using SAS.Model.Factual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model.Abstract
{
    public interface IGroup : IDbObject
    {
        string Name { get; set; }
        IEnumerable<ILocation> Locations { get; set; }
        GroupType Type { get; set; }
    }
}
