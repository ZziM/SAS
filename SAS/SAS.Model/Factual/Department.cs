using SAS.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
