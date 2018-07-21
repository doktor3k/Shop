namespace ClothShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FewChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Images", "ItemId", "dbo.Items");
            DropIndex("dbo.Images", new[] { "ItemId" });
            RenameColumn(table: "dbo.Images", name: "ItemId", newName: "Item_Id");
            AddColumn("dbo.Items", "PricePerOne", c => c.Double(nullable: false));
            AddColumn("dbo.Items", "Description", c => c.String(unicode: false, storeType: "text"));
            AddColumn("dbo.Items", "NumberOfItem", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "TransactionId", c => c.Int(nullable: false));
            AddColumn("dbo.Images", "ImagePath", c => c.String());
            AlterColumn("dbo.Images", "Item_Id", c => c.Int());
            CreateIndex("dbo.Images", "Item_Id");
            AddForeignKey("dbo.Images", "Item_Id", "dbo.Items", "Id");
            DropColumn("dbo.Items", "Value");
            DropColumn("dbo.Items", "Info");
            DropColumn("dbo.Items", "QuantityStorage");
            DropColumn("dbo.Images", "ImageName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "ImageName", c => c.String());
            AddColumn("dbo.Items", "QuantityStorage", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "Info", c => c.String(unicode: false, storeType: "text"));
            AddColumn("dbo.Items", "Value", c => c.Double(nullable: false));
            DropForeignKey("dbo.Images", "Item_Id", "dbo.Items");
            DropIndex("dbo.Images", new[] { "Item_Id" });
            AlterColumn("dbo.Images", "Item_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Images", "ImagePath");
            DropColumn("dbo.Items", "TransactionId");
            DropColumn("dbo.Items", "NumberOfItem");
            DropColumn("dbo.Items", "Description");
            DropColumn("dbo.Items", "PricePerOne");
            RenameColumn(table: "dbo.Images", name: "Item_Id", newName: "ItemId");
            CreateIndex("dbo.Images", "ItemId");
            AddForeignKey("dbo.Images", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
    }
}
