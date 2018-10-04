using System.Collections.Generic;

namespace SAS.Model.Abstract
{
    public interface IDepartment : IDbObject
    {
        string Name { get; set; }
        IEnumerable<IEmployee> Employees { get; set; }
    }
}
