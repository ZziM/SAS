namespace SAS.Model.Abstract
{
    public interface ICustomerEmployee : ICustomer
    {
        string SAPNumber { get; set; }
        string Username { get; set; }
        IDepartment Department { get; set; }
        ICompany Company { get; set; }
    }
}
