using SAS.Model;
using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Repository.Repository.Factual
{
    public class RequestRepository : BaseRepository, IRepository<IRequest>
    {
        public RequestRepository(SecurityAreaSystemContext db) : base(db)
        {
        }

        public void Create(IRequest _)
        {
            _db.Requests.Add(_ as Request);
        }

        public void Delete(IRequest _)
        {
            _db.Requests.Remove(_ as Request);
        }

        public IQueryable<IRequest> ReadAll()
        {
            return _db.Requests;
        }

        public IQueryable<IRequest> ReadAll(Expression<Func<IRequest, bool>> expression)
        {
            return _db.Requests.Where(expression);
        }

        public void Update(IRequest _)
        {
            _db.Entry(_).State = EntityState.Modified;
        }
    }
}
