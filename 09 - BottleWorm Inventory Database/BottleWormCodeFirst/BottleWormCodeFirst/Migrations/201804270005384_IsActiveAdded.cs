namespace BottleWormCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsActiveAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsActive", c => c.Boolean(nullable: false, defaultValue: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsActive");
        }
    }
}
