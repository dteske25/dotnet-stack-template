using System.Linq.Expressions;
using DotnetStack.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotnetStack.DataAccessHandlers.Infrastructure.EntityFramework
{
    public abstract class BaseEntityHandler<T> : IBaseEntityHandler<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly IDbSetFactory _dbSetFactory;

        public BaseEntityHandler(IDbSetFactory dbSetFactory)
        {
            _dbSet = dbSetFactory.CreateDbSet<T>();
            _dbSetFactory = dbSetFactory;
        }

        #region IRepository<T> Members

        public IQueryable<T> AsQueryable()
        {
            return _dbSet;
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = AsQueryable();
            return PerformInclusions(includeProperties, query);
        }

        public bool Contains(object id)
        {
            return _dbSet.Find(id) != null;
        }

        public bool Contains(T entity)
        {
            return _dbSet.Find(entity) != null;
        }

        public bool Contains(Expression<Func<T, bool>> where)
        {
            return _dbSet.Any(where);
        }

        public T? Find(object id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> where,
                                   params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = AsQueryable();
            query = PerformInclusions(includeProperties, query);
            return query.Where(where);
        }

        public T? Single(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = AsQueryable();
            query = PerformInclusions(includeProperties, query);
            return query.SingleOrDefault(where);
        }

        public T? First(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = AsQueryable();
            query = PerformInclusions(includeProperties, query);
            return query.FirstOrDefault(where);
        }

        public void Delete(T entity)
        {
            _dbSetFactory.ChangeObjectState(entity, EntityState.Deleted);
        }

        public T Insert(T entity)
        {
            return _dbSet.Add(entity).Entity;
        }

        public void Update(T entity)
        {
            _dbSetFactory.ChangeObjectState(entity, EntityState.Modified);
        }

        public T Refresh(T entity)
        {
            _dbSetFactory.RefreshEntity(ref entity);
            return entity;
        }

        #endregion

        private static IQueryable<T> PerformInclusions(IEnumerable<Expression<Func<T, object>>> includeProperties,
                                                       IQueryable<T> query)
        {
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
