using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetStack.DataAccessHandlers.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace DotnetStack.Handlers.Infrastructure
{
    public  class DotnetStackContextAdapter: IDbSetFactory, IDbContext
    {
        private readonly DbContext _context;

        public DotnetStackContextAdapter(DbContext context)
        {
            _context = context;
        }

        public void ChangeObjectState(object entity, EntityState state)
        {
            _context.Entry(entity).State = state;
        }

        public DbSet<T> CreateDbSet<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void RefreshEntity<T>(ref T entity) where T : class
        {
            var entry = _context.Entry(entity);
            entry.Reload();
            entity = entry.Entity;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
