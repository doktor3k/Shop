namespace ClothShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemChange : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "TransactionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "TransactionId", c => c.Int(nullable: false));
        }
    }
}
