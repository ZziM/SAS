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
    public class RequestedGroupRepository : BaseRepository, IRepository<IRequestedGroup>
    {
        public RequestedGroupRepository(SecurityAreaSystemContext db) : base(db)
        {
        }

        public void Create(IRequestedGroup _)
        {
            _db.RequestedGroups.Add(_ as RequestedGroup);
        }

        public void Delete(IRequestedGroup _)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IRequestedGroup> ReadAll()
        {
            return _db.RequestedGroups;
        }

        public IQueryable<IRequestedGroup> ReadAll(Expression<Func<IRequestedGroup, bool>> expression)
        {
            return _db.RequestedGroups.Where(expression);
        }

        public void Update(IRequestedGroup _)
        {
            throw new NotImplementedException();
        }
    }
}
