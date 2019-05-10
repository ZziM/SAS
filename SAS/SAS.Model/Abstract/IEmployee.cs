namespace SAS.Model.Abstract
{
    public interface IEmployee : IUser
    {
        string Username { get; set; }
        IDepartment Department { get; set; }
        ICompany Company { get; set; }
    }
}
