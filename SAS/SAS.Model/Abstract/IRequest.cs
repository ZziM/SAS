using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Model.Abstract
{
    public interface IRequest : IDbObject
    {
        IEmployee Creator { get; set; }
        ICustomer Customer { get; set; }
        string Name { get; set; }
        string AdditionalInformation { get; set; }
        string BusinessReason { get; set; }
        DateTime CreateDate { get; set; }
        DateTime StartAccessDate { get; set; }
        DateTime? EndAccessDate { get; set; }
        IQueryable<IRequestedGroup> Groups { get; }
    }
}
