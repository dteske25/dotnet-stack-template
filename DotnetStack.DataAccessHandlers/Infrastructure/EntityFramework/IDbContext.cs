using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetStack.DataAccessHandlers.Infrastructure.EntityFramework
{
    public interface IDbContext : IDisposable
    {
        void SaveChanges();
    }
}
