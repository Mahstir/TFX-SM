namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDateOfPaymentAndReturnFromPlanAndAddToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfpayment", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "DateOfReturn", c => c.DateTime(nullable: false));
            DropColumn("dbo.Plans", "DateOfpayment");
            DropColumn("dbo.Plans", "DateOfReturn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plans", "DateOfReturn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Plans", "DateOfpayment", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "DateOfReturn");
            DropColumn("dbo.Customers", "DateOfpayment");
        }
    }
}
