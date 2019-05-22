using SAS.Model.Factual;
using System;
using System.Linq;

namespace SAS.Model.Abstract
{
    public interface IRequest : IDbObject
    {
        IEmployee Creator { get; set; }
        ICustomer Customer { get; set; }
        string AdditionalInformation { get; set; }
        string BusinessReason { get; set; }
        DateTime CreateDate { get; set; }
        DateTime StartAccessDate { get; set; }
        DateTime? EndAccessDate { get; set; }
        IQueryable<IRequestedGroup> Groups { get; }
        RequestAccess RequestAccess { get; set; }
        EnumRequestState State { get; set; }
        RequestType Type { get; }
    }
}
