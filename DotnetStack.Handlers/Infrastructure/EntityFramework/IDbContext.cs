using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetStack.Handlers.Infrastructure.EntityFramework
{
    public interface IDbContext : IDisposable
    {
        void SaveChanges();
    }
}
