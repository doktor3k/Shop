namespace ClothShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixItemAndImageRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Images", "Item_Id", "dbo.Items");
            DropIndex("dbo.Images", new[] { "Item_Id" });
            RenameColumn(table: "dbo.Images", name: "Item_Id", newName: "ItemId");
            AlterColumn("dbo.Images", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Images", "ItemId");
            AddForeignKey("dbo.Images", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "ItemId", "dbo.Items");
            DropIndex("dbo.Images", new[] { "ItemId" });
            AlterColumn("dbo.Images", "ItemId", c => c.Int());
            RenameColumn(table: "dbo.Images", name: "ItemId", newName: "Item_Id");
            CreateIndex("dbo.Images", "Item_Id");
            AddForeignKey("dbo.Images", "Item_Id", "dbo.Items", "Id");
        }
    }
}
