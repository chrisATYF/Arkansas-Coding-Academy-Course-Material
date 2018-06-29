namespace BottleWormCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefaultDateAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CreateDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Customers", "UpdateDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Inventories", "CreateDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Inventories", "UpdateDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Transactions", "CreateDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Transactions", "UpdateDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Transactions", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Inventories", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Inventories", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
