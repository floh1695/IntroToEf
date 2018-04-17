namespace IntroToEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "YearReleased", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Rating", c => c.Double(nullable: false));
            AlterColumn("dbo.Movies", "YearReleased", c => c.String());
        }
    }
}
