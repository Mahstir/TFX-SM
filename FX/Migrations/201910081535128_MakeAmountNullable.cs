namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeAmountNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Amount", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Amount", c => c.Double(nullable: false));
        }
    }
}
