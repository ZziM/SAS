using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public abstract class Customer : DbObject, ICustomer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AdditionalInformation { get; set; }
    }
}
