
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Kians.EduxBee.Infrastructure.Repository
{
    using Kians.EduxBee.Core.Entity;
    using Kians.EduxBee.Infrastructure.Interfaces;
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private EduxBeeEntities _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(EduxBeeEntities context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual TEntity Insert(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }

        public virtual TEntity Update(TEntity entityToUpdate)
        {
            var updatedEntity = _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            return updatedEntity;
        }

    }
}
