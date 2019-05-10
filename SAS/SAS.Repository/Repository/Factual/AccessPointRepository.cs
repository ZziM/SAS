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
    class AccessPointRepository : BaseRepository, IRepository<IAccessPoint>
    {
        public AccessPointRepository(SecurityAreaSystemContext db) : base(db)
        {
        }

        public void Create(IAccessPoint _)
        {
            throw new NotImplementedException();
        }

        public void Delete(IAccessPoint _)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IAccessPoint> ReadAll()
        {
            return _db.AccessPoints;
        }

        public IQueryable<IAccessPoint> ReadAll(Expression<Func<IAccessPoint, bool>> expression)
        {
            return _db.AccessPoints.Where(expression);
        }

        public void Update(IAccessPoint _)
        {
            throw new NotImplementedException();
        }
    }
}
