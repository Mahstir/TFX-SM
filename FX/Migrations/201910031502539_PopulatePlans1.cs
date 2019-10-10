namespace FX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePlans1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Plans (Id, Name, Amount, DailyInterest, Rate, DurationInDays) VALUES (1, 'Beginner', 300, 0.02, 0.24, 12)");
            Sql("INSERT INTO Plans (Id, Name, Amount, DailyInterest, Rate, DurationInDays) VALUES (2, 'Expert', 500, 0.02, 1, 5)");
            Sql("INSERT INTO Plans (Id, Name, Amount, DailyInterest, Rate, DurationInDays) VALUES (3, 'Business Pro', 500, 0.04, 2, 5)");
            Sql("INSERT INTO Plans (Id, Name, Amount, DailyInterest, Rate, DurationInDays) VALUES (4, 'Advanced', 200, 0.02, 2, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
