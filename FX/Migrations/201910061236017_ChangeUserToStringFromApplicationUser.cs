namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserToStringFromApplicationUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Customers", new[] { "User_Id" });
            AddColumn("dbo.Customers", "user", c => c.String());
            DropColumn("dbo.Customers", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "User_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Customers", "user");
            CreateIndex("dbo.Customers", "User_Id");
            AddForeignKey("dbo.Customers", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
