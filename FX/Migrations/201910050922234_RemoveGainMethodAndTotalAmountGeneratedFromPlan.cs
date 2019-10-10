namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveGainMethodAndTotalAmountGeneratedFromPlan : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Plans", "TotalAmountGenerated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plans", "TotalAmountGenerated", c => c.Double(nullable: false));
        }
    }
}
