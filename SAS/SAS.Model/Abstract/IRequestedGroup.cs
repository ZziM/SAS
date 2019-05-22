using SAS.Model.Factual;
using System.Linq;

namespace SAS.Model.Abstract
{
    public interface IRequestedGroup : IDbObject
    {
        IRequest Request { get; set; }
        IGroup Group { get;set; }
        IQueryable<IRequestedAccessPoint> AccessPoints { get; }
        RequestGroupStatus GroupStatus { get; set; }
    }
}
