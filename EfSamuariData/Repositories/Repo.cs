using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EfSamuariDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EfSamuariData.Repositories
{
    public class Repo<TEntity> : IRepo<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _context;


        public Repo()
        {
            _context = new SamuraiContext().Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.ToList();
        }

        public TEntity Find(TEntity entity)
        {
            return _context.Find(entity);
        }

        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Where(predicate);
        }

        public IEnumerable<TEntity> FindAll(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

    }


}
