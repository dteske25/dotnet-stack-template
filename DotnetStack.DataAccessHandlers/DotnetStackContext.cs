using DotnetStack.Core.Entities;
using DotnetStack.DataAccessHandlers.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DotnetStack.DataAccessHandlers
{
    public class DotnetStackContext : DbContext
    {
        public DbSet<Quote>? Quotes { get; set; }

        public DotnetStackContext() { }
        public DotnetStackContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfiguration.OnModelCreating(modelBuilder);
        }
    }
}
