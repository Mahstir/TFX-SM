namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAmountToCustomerClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Amount", c => c.Double(nullable: false));
            DropColumn("dbo.Customers", "Wallet");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Wallet", c => c.Double(nullable: false));
            DropColumn("dbo.Customers", "Amount");
        }
    }
}
