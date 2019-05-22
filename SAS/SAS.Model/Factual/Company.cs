using SAS.Model.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class Company : DbObject, ICompany
    {
        public string Name { get; set; }
        IQueryable<IEmployee> ICompany.Employees
        {
            get => Employees.AsQueryable();
        }

        #region EF
        public virtual ICollection<Employee> Employees { get; set; }
        #endregion
    }
}
