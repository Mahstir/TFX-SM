namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWalletToCustomerAndTotalAmountGeneratedToPlan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Wallet", c => c.Double(nullable: false));
            AddColumn("dbo.Plans", "TotalAmountGenerated", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Plans", "TotalAmountGenerated");
            DropColumn("dbo.Customers", "Wallet");
        }
    }
}
