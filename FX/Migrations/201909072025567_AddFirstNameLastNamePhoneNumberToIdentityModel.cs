namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFirstNameLastNamePhoneNumberToIdentityModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
