using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Abstract
{
    public interface IDepartment : IDbObject
    {
        string Name { get; set; }
        IQueryable<IEmployee> Employees { get; }
    }
}
