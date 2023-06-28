using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFAssignment2
{
    public class DataContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public string DbPath { get; set; }

        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            DbPath = Path.Join(path, "day3.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
