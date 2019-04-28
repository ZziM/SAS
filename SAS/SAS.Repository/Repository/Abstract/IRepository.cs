using System;
using System.Linq;
using System.Linq.Expressions;

namespace SAS.Repository.Repository.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Create(T _);
        IQueryable<T> ReadAll();
        IQueryable<T> ReadAll(Expression<Func<T, bool>> expression);
        void Update(T _);
        void Delete(T _);
    }
}
