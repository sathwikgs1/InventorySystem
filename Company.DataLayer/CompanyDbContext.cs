using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Company.DomainModels;

namespace Company.DataLayer
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("name=MyConnectionString")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<InvenDbContext, Configuration>());
        }
        public DbSet<Inventory> Inventories { get; set; }
    }
}
