using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EfSamuariDomain.Interfaces
{
    public interface IRepo<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Find(TEntity entity);
        IEnumerable<TEntity>FindAll(Expression<Func<TEntity, bool>> predicate);
        void Delete(TEntity entity);
        IEnumerable<TEntity> AllInclude(params Expression<Func<TEntity, object>>[] includeProperties);
    }
}