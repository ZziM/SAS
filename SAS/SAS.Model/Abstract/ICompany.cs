using System.Linq;

namespace SAS.Model.Abstract
{
    public interface ICompany : IDbObject
    {
        string Name { get; set; }
        IQueryable<IEmployee> Employees { get; }
    }
}