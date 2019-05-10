using SAS.Model;
using SAS.Model.Abstract;
using SAS.Model.Factual;
using SAS.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Repository.Repository.Factual
{
    public class RequestedAccessPointRepository : BaseRepository, IRepository<IRequestedAccessPoint>
    {
        public RequestedAccessPointRepository(SecurityAreaSystemContext db) : base(db)
        {
        }

        public void Create(IRequestedAccessPoint _)
        {
            _db.RequestedAccessPoints.Add(_ as RequestedAccessPoint);
        }

        public void Delete(IRequestedAccessPoint _)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IRequestedAccessPoint> ReadAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<IRequestedAccessPoint> ReadAll(Expression<Func<IRequestedAccessPoint, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(IRequestedAccessPoint _)
        {
            throw new NotImplementedException();
        }
    }
}
