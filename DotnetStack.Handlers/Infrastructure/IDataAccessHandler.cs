using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DotnetStack.Core.Types;

namespace DotnetStack.Handlers.Infrastructure
{
    internal interface IDataAccessHandler<T> where T : IBaseDataObject
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> where);
        T Single(Expression<Func<T, bool>> where);
        T First(Expression<Func<T, bool>> where);
        void Delete(Expression<Func<T, bool>> where);
        void Delete(T entity);
        T Insert(T entity);
        void InsertMany(IEnumerable<T> entities);
        void Update(T entity);
    }
}
