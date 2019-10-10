namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUserPropertyFromCustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "user");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "user", c => c.String());
        }
    }
}
