namespace BottleWormCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAndUpdateDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Inventories", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Inventories", "UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Transactions", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Transactions", "UpdateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "UpdateDate");
            DropColumn("dbo.Transactions", "CreateDate");
            DropColumn("dbo.Inventories", "UpdateDate");
            DropColumn("dbo.Inventories", "CreateDate");
            DropColumn("dbo.Customers", "UpdateDate");
            DropColumn("dbo.Customers", "CreateDate");
        }
    }
}
