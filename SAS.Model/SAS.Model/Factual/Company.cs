using System.Collections.Generic;
using System.Linq;
using SAS.Model.Abstract;

namespace SAS.Model.Factual
{
    public class Company : DbOjbect, ICompany
    {
        public string Name { get; set; }
        IEnumerable<IEmployee> ICompany.Employees
        {
            get => Employees;
            set
            {
                if(value is IEnumerable<Employee> employees)
                {
                    Employees = employees.ToList();
                }
            }
        }

        #region EF
        public virtual ICollection<Employee> Employees { get; set; }
        #endregion
    }
}
