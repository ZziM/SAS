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
    public class RequestStateRepository : BaseRepository, IRepository<IRequestState>
    {
        public RequestStateRepository(SecurityAreaSystemContext db) : base(db)
        {
        }

        public void Create(IRequestState _)
        {
            throw new NotImplementedException();
        }

        public void Delete(IRequestState _)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IRequestState> ReadAll()
        {
            return _db.RequestStates;
        }

        public IQueryable<IRequestState> ReadAll(Expression<Func<IRequestState, bool>> expression)
        {
            return _db.RequestStates.Where(expression);
        }

        public void Update(IRequestState _)
        {
            throw new NotImplementedException();
        }
    }
}
