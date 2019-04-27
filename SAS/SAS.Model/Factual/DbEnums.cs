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
}