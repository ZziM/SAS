using SAS.Model.Factual;
using System.Linq;

namespace SAS.Model.Abstract
{
    public interface IGroup : IDbObject
    {
        string Name { get; set; }
        IQueryable<ILocation> Locations { get; }
        GroupType Type { get; set; }
    }
}
