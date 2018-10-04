using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model.Abstract
{
    public interface ILocation : IDbObject
    {
        string Name { get; set; }
        IEnumerable<IEmployee> LocationManagers { get; set; }
        IEnumerable<IGroup> Areas { get; set; }
    }
}
