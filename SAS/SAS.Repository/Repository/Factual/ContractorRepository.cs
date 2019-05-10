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
    public class ContractorRepository : BaseRepository, IRepository<IContractor>
    {
        public ContractorRepository(SecurityAreaSystemContext db) : base(db)
        {

        }
        public void Create(IContractor _)
        {
            throw new NotImplementedException();
        }

        public void Delete(IContractor _)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IContractor> ReadAll()
        {
            return _db.Contractors;
        }

        public IQueryable<IContractor> ReadAll(Expression<Func<IContractor, bool>> expression)
        {
            return _db.Contractors.Where(expression);
        }

        public void Update(IContractor _)
        {
            throw new NotImplementedException();
        }
    }
}
