namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlans : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Amount = c.Double(nullable: false),
                        DailyInterest = c.Single(nullable: false),
                        Rate = c.Double(nullable: false),
                        DurationInDays = c.Byte(nullable: false),
                        DateOfpayment = c.DateTime(nullable: false),
                        DateOfReturn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "PlanId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "PlanId");
            AddForeignKey("dbo.Customers", "PlanId", "dbo.Plans", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "PlanId", "dbo.Plans");
            DropIndex("dbo.Customers", new[] { "PlanId" });
            DropColumn("dbo.Customers", "PlanId");
            DropTable("dbo.Plans");
        }
    }
}
