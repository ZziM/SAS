using SAS.Model.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SAS.Model.Factual
{
    public class Department : DbObject, IDepartment
    {
        public string Name { get; set; }
        IQueryable<IEmployee> IDepartment.Employees
        {
            get => Employees.AsQueryable();
        }

        #region EF
        public virtual ICollection<Employee> Employees { get; set; }
        #endregion
    }
}
