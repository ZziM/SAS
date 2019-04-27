using System.Linq;

namespace SAS.Model.Abstract
{
    public interface IAccessPoint : IDbObject
    {
        string Name { get; set; }
        IQueryable<IEmployee> AccessPointManagers { get; }
        IQueryable<IGroup> Groups { get; }
    }
}
