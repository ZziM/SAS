namespace SAS.Model.Abstract
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string AdditionalInformation { get; set; }
    }
}
