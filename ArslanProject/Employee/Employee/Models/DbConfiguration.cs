using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    //Microsoft.EntityFrameworkCore.tools
    //Microsoft.EntityFrameworkCore.sqlServer
    public class DbConfiguration :DbContext
    {
        public DbSet<Employee1> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog= EmployeeDBPractice; integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
