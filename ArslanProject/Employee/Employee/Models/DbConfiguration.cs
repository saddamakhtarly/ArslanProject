using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Models.Address;

namespace Employee.Models
{
    //Microsoft.EntityFrameworkCore.tools
    //Microsoft.EntityFrameworkCore.sqlServer
    public class DbConfiguration :DbContext
    {
        public DbSet<Employee1> Employees { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Province> provinces { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Neighborhood> neighborhoods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog= EmployeeDBPractice; integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Province>()
                .HasOne<Country>(x => x.Country)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<City>().HasOne<Province>(x => x.Province).WithMany().OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Neighborhood>()
                .HasOne<City>(x => x.City)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
