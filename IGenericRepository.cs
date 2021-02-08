using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Kians.EduxBee.Infrastructure.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        TEntity GetByID(object id);
        TEntity Insert(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entity);
        TEntity Update(TEntity entity);

        IEnumerable<TEntity> GetAll();
    }
}
