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
    public class GroupRepository : BaseRepository, IRepository<IGroup>
    {
        public GroupRepository(SecurityAreaSystemContext db) : base(db)
        {
        }

        public void Create(IGroup _)
        {
            throw new NotImplementedException();
        }

        public void Delete(IGroup _)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IGroup> ReadAll()
        {
            return _db.Groups;
        }

        public IQueryable<IGroup> ReadAll(Expression<Func<IGroup, bool>> expression)
        {
            return _db.Groups.Where(expression);
        }

        public void Update(IGroup _)
        {
            throw new NotImplementedException();
        }
    }
}
