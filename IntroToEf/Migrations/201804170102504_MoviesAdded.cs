namespace IntroToEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        YearReleased = c.String(),
                        Genre = c.String(),
                        Tagline = c.String(),
                        Rating = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
