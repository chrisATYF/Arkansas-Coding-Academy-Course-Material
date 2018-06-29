using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BankWorm.codefirst.Models;

namespace BankWorm.codefirst
{
    public class BankWormContext : DbContext
    {
        public BankWormContext()
            : base("Name=BankWormContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BankWormContext, Migrations.Configuration>());
            
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Do stuff

            base.OnModelCreating(modelBuilder);


        }
    }
}
