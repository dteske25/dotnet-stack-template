﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetStack.Core.Types;
using Microsoft.EntityFrameworkCore;

namespace DotnetStack.Handlers.Infrastructure
{
    public class DotnetStackContext : DbContext
    {
        public DbSet<Quote>? Quotes { get; set; }

        public string DbPath { get; private set; }

        public DotnetStackContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}dotnetStack.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
