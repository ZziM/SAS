using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public class CustomerJTI : CustomerEmployee, ICustomerJTI
    {
        public string TabNumber { get; set; }

        public CustomerJTI()
        {

        }
    }
}
