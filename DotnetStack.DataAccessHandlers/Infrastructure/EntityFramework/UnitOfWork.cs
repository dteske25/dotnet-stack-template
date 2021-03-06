using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetStack.Core.Interfaces;

namespace DotnetStack.DataAccessHandlers.Infrastructure.EntityFramework
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IDbContext _dbContext;

        public UnitOfWork(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        #endregion

        #region IUnitOfWork Members

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        #endregion
    }
}
