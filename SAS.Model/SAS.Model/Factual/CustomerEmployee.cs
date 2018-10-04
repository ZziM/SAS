using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public abstract class CustomerEmployee : Customer, ICustomerEmployee
    {
        public string SAPNumber { get; set; }
        public string Username { get; set; }
        IDepartment ICustomerEmployee.Department
        {
            get => Department;
            set
            {
                if (value is Department department)
                    Department = department;
            }
        }
        ICompany ICustomerEmployee.Company
        {
            get => Company;
            set
            {
                if (value is Company company)
                    Company = company;
            }
        }

        #region EF
        public int DepartmentID { get; set; }
        public int CompanyID { get; set; }
        public virtual Department Department { get; set; }
        public virtual Company Company { get; set; }
        #endregion
    }
}