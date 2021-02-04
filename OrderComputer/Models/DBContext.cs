using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderComputer.Models
{
    public class DBContext : DbContext
    {
        public DBContext()
        {}

        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-FH2RBI3\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=true;");
        }
    }
}
