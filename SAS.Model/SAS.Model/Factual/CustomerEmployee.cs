using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public abstract class CustomerEmployee : Customer, ICustomerEmployee
    {
        public string SAPNumber { get; set; }
        public string Username { get; set; }
        public IDepartment Department { get; set; }
        public ICompany Company { get; set; }

        #region EF
        #endregion
    }
}