using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottleWormCodeFirst.Models;

namespace BottleWormCodeFirst
{
    public class BottleContext : DbContext
    {
        public BottleContext()
            : base("Name=BottleWormContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BottleContext, Migrations.Configuration>());
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Employees> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(i => i.IsActive).HasColumnOrder(1);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var addedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Added);
            foreach (var entity in addedEntities)
            {
                if (entity.Entity is EntityBase test)
                {
                    test.CreateDate = DateTime.UtcNow;
                }
            }

            var moddedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified);
            foreach (var entity in moddedEntities)
            {
                if (entity.Entity is EntityBase test)
                {
                    test.UpdateDate = DateTime.UtcNow;
                }
            }

            return base.SaveChanges();
        }
    }
}
