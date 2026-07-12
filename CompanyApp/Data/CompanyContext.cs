using CompanyApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Data
{
    internal class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CompanyDB"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
