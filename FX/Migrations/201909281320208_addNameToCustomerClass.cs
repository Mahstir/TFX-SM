namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNameToCustomerClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Name");
        }
    }
}
