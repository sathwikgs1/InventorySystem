namespace InventorySystemExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Inventory", "DateOfPurchase");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inventory", "DateOfPurchase", c => c.DateTime());
        }
    }
}
