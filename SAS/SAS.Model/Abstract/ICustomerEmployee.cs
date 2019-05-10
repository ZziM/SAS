namespace SAS.Model.Abstract
{
    public interface ICustomerEmployee : ICustomer
    {
        string SAPNumber { get; set; }
        string Username { get; set; }
        string Department { get; set; }
        string Company { get; set; }
    }
}
