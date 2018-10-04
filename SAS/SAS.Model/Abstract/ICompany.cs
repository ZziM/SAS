using System.Collections;
using System.Collections.Generic;

namespace SAS.Model.Abstract
{
    public interface ICompany : IDbObject
    {
        string Name { get; set; }
        IEnumerable<IEmployee> Employees { get; set; }
    }
}