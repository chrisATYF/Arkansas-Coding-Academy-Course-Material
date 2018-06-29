namespace BankWorm.codefirst.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BankWorm.codefirst.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BankWorm.codefirst.BankWormContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BankWorm.codefirst.BankWormContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var chris = new Customer
            {
                Name = "Chris McDonald",
                Accounts = new List<Account>
                {
                    new Account
                    {
                        Name = "Main Checking",
                        AccountType = AccountType.Debit,
                        AccountOpenedDate = DateTime.UtcNow
                    }
                }
            };

            context.Customers.AddOrUpdate(chris);
        }
    }
}
