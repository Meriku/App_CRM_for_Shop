namespace CRM_BL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0705 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Receipts", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Receipts", "Price");
        }
    }
}
