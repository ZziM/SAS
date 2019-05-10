using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public abstract class CustomerEmployee : Customer, ICustomerEmployee
    {
        public string SAPNumber { get; set; }
        public string Username { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
    }
}