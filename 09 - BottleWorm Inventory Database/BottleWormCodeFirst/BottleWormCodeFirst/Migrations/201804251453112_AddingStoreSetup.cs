namespace BottleWormCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingStoreSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartCustomer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CartCustomer_Id)
                .Index(t => t.CartCustomer_Id);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShoppingCart_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCart_Id)
                .Index(t => t.ShoppingCart_Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            AddColumn("dbo.Customers", "Cart_Id", c => c.Int());
            AddColumn("dbo.Customers", "CustomerCart_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Cart_Id");
            CreateIndex("dbo.Customers", "CustomerCart_Id");
            AddForeignKey("dbo.Customers", "Cart_Id", "dbo.ShoppingCarts", "Id");
            AddForeignKey("dbo.Customers", "CustomerCart_Id", "dbo.ShoppingCarts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Customers", "CustomerCart_Id", "dbo.ShoppingCarts");
            DropForeignKey("dbo.Customers", "Cart_Id", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCarts", "CartCustomer_Id", "dbo.Customers");
            DropForeignKey("dbo.Inventories", "ShoppingCart_Id", "dbo.ShoppingCarts");
            DropIndex("dbo.Transactions", new[] { "Customer_Id" });
            DropIndex("dbo.Inventories", new[] { "ShoppingCart_Id" });
            DropIndex("dbo.ShoppingCarts", new[] { "CartCustomer_Id" });
            DropIndex("dbo.Customers", new[] { "CustomerCart_Id" });
            DropIndex("dbo.Customers", new[] { "Cart_Id" });
            DropColumn("dbo.Customers", "CustomerCart_Id");
            DropColumn("dbo.Customers", "Cart_Id");
            DropTable("dbo.Transactions");
            DropTable("dbo.Inventories");
            DropTable("dbo.ShoppingCarts");
        }
    }
}
