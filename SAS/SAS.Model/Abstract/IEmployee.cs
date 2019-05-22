namespace SAS.Model.Abstract
{
    public interface IEmployee : IUser
    {
        string Username { get; set; }
        string SAPNumber { get; set; }
        IDepartment Department { get; set; }
        ICompany Company { get; set; }
    }
}
