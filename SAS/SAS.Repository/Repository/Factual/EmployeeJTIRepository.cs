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
    public class EmployeeJTIRepository : BaseRepository, IRepository<IEmployeeJTI>
    {
        public EmployeeJTIRepository(SecurityAreaSystemContext db) : base(db)
        {
        }

        public void Create(IEmployeeJTI _)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEmployeeJTI _)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IEmployeeJTI> ReadAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<IEmployeeJTI> ReadAll(Expression<Func<IEmployeeJTI, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(IEmployeeJTI _)
        {
            throw new NotImplementedException();
        }
    }
}
