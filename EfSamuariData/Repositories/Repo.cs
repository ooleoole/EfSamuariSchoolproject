using System.Collections.Generic;
using System.Linq;
using EfSamuariDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EfSamuariData.Repositories
{
    public class Repo<TEntity> : IRepo<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _repo;


        public Repo()
        {
            _repo = new SamuraiContext().Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _repo.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repo.ToList();
        }

        public TEntity Find(TEntity entity)
        {
            return _repo.Find(entity);
        }

        public void Delete(TEntity entity)
        {
            _repo.Remove(entity);
        }

    }


}
