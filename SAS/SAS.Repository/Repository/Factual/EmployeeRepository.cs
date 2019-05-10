using SAS.Model;
using SAS.Model.Abstract;
using SAS.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Repository.Repository.Factual
{
    class EmployeeRepository : BaseRepository, IRepository<IEmployee>
    {
        public EmployeeRepository(SecurityAreaSystemContext db) : base(db)
        {
        }

        public void Create(IEmployee _)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEmployee _)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IEmployee> ReadAll()
        {
            return _db.Employees;
        }

        public IQueryable<IEmployee> ReadAll(Expression<Func<IEmployee, bool>> expression)
        {
            return _db.Employees.Where(expression);
        }

        public void Update(IEmployee _)
        {
            throw new NotImplementedException();
        }
    }
}
