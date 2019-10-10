namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeDatesInCustomerNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateOfpayment", c => c.DateTime());
            AlterColumn("dbo.Customers", "DateOfReturn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateOfReturn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "DateOfpayment", c => c.DateTime(nullable: false));
        }
    }
}
