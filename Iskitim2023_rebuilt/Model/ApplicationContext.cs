using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskitim2023_rebuilt.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<pollution> polutions { get; set; } = null!;
        public DbSet<point> points { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./Diplom.db");
        }
    }
}
