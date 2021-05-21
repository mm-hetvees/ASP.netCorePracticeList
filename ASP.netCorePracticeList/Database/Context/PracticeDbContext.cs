using ASP.netCorePracticeList.Database.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCorePracticeList.Database.Context
{
    public class PracticeDbContext : DbContext
    {
        //public PracticeDbContext(DbContextOptions options) : base(options)
        //{
        //}

        public DbSet<UserTableDetails> UserTableDetails { get; set; }
        public DbSet<CustomerEntryTable> CustomerEntryTable { get; set; }
        public DbSet<EmployeeTableDetails> EmployeeTableDetails { get; set; }
        public DbSet<ClientTableData> ClientTableData { get; set; }
        public DbSet<EmployeeDepartmentTableDetails> ClientTaEmployeeDepartmentTableDetailsbleData { get; set; }
        public DbSet<MobileDetails> MobileDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=(LocalDB)\\MSSQLLocalDB;initial catalog=training;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
    }
}
