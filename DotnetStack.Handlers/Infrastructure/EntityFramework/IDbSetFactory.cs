using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotnetStack.Handlers.Infrastructure
{
    public interface IDbSetFactory : IDisposable
    {
        DbSet<T> CreateDbSet<T>() where T : class;
        void ChangeObjectState(object entity, EntityState state);
        void RefreshEntity<T>(ref T entity) where T : class;
    }
}
