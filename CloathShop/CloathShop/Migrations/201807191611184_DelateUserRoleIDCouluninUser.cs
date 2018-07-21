namespace ClothShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelateUserRoleIDCouluninUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", new[] { "UserRoleID_UserId", "UserRoleID_RoleId" }, "dbo.AspNetUserRoles");
            DropIndex("dbo.AspNetUsers", new[] { "UserRoleID_UserId", "UserRoleID_RoleId" });
            DropColumn("dbo.AspNetUsers", "UserRoleID_UserId");
            DropColumn("dbo.AspNetUsers", "UserRoleID_RoleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "UserRoleID_RoleId", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "UserRoleID_UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUsers", new[] { "UserRoleID_UserId", "UserRoleID_RoleId" });
            AddForeignKey("dbo.AspNetUsers", new[] { "UserRoleID_UserId", "UserRoleID_RoleId" }, "dbo.AspNetUserRoles", new[] { "UserId", "RoleId" });
        }
    }
}
