using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EfSamuariDomain;
using EfSamuariDomain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EfSamuariData.Repositories
{
    public class Repo<TEntity> : IRepo<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _set;
        private readonly DbContext _context;

        public Repo()
        {
            _context = new SamuraiContext();
            _set = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _set.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _set.ToList();
        }

        public TEntity Find(TEntity entity)
        {
            return _set.Find(entity);
        }

        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _set.Where(predicate);
        }

        public IEnumerable<TEntity> FindAll(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            _set.Remove(entity);
        }


    }


}
