namespace SAS.Model.Abstract
{
    public interface IEmployee : IUser
    {
        IDepartment Department { get; set; }
        ICompany Company { get; set; }
    }
}
