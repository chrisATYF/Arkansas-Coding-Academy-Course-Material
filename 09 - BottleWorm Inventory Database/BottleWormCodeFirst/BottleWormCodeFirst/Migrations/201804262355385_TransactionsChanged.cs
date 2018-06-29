namespace BottleWormCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransactionsChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "Customer_Id" });
            RenameColumn(table: "dbo.Transactions", name: "Customer_Id", newName: "CustomerId");
            AlterColumn("dbo.Transactions", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "CustomerId");
            AddForeignKey("dbo.Transactions", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "CustomerId" });
            AlterColumn("dbo.Transactions", "CustomerId", c => c.Int());
            RenameColumn(table: "dbo.Transactions", name: "CustomerId", newName: "Customer_Id");
            CreateIndex("dbo.Transactions", "Customer_Id");
            AddForeignKey("dbo.Transactions", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
