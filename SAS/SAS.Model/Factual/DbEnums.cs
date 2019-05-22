using System;

namespace SAS.Model.Factual
{
    public enum ActiveStatus
    {
        Disabled,
        Enabled
    }

    public enum UserType
    {
        JTI,
        Contractor,
        Visitor
    }

    public enum GroupType
    {
        ABC,
        FortNet,
        Other
    }

    public enum RequestType
    {
        JTI,
        Contractor,
        Visitor
    }

    public enum CustomerType
    {
        JTI,
        Contractor,
        Visitor
    }

    public enum RequestGroupStatus
    {
        OnApproval
    }

    public enum RequestAccessPointStatus
    {
        OnApproval,
        Approved,
        Rejected
    }
    [Flags]
    public enum RequestAccess
    {
        None = 0,
        LocationManager = 1 
    }

    public enum EnumRequestState
    {
        None = 0,
        OnLocationManager = 1,
        OnSecurityImplementation = 2,
        Rejected,
        PartiallyApproved,
        Approved,
        Archived
    }
}