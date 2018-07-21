namespace ClothShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserEntityUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Surname", c => c.String());
            DropColumn("dbo.AspNetUsers", "Surename");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Surename", c => c.String());
            DropColumn("dbo.AspNetUsers", "Surname");
        }
    }
}
