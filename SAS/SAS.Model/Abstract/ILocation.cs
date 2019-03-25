using System.Linq;

namespace SAS.Model.Abstract
{
    public interface ILocation : IDbObject
    {
        string Name { get; set; }
        IQueryable<IEmployee> LocationManagers { get; }
        IQueryable<IGroup> Areas { get; }
    }
}
