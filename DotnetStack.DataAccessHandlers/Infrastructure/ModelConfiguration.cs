using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetStack.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetStack.DataAccessHandlers.Infrastructure
{
    public class ModelConfiguration
    {
        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().HasKey(q => q.Id);
        }
    }
}
