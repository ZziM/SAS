using SAS.Model.Factual;
using System;

namespace SAS.Model.Abstract
{
    public interface IRequestedAccessPoint : IDbObject
    {
        IRequestedGroup Group { get; set; }
        IAccessPoint AccessPoint { get; set; }
        string AccessPointName { get; set; }
        RequestAccessPointStatus AccessPointStatus { get; set; }
    }
}
