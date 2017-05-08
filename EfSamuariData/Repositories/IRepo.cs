using System.Collections.Generic;

namespace EfSamuariData.Repositories
{
    public interface IRepo<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Find(TEntity entity);
        void Delete(TEntity entity);
    }
}