namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String());
            DropColumn("dbo.Customers", "Name");
            DropColumn("dbo.Customers", "Wallet");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Wallet", c => c.Double(nullable: false));
            AddColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "Email");
        }
    }
}
