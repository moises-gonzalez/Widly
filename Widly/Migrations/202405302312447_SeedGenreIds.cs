namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenreIds : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Horror')");
            Sql("INSERT INTO Genres (Name) VALUES ('Suspense')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Terror')");
            Sql("INSERT INTO Genres (Name) VALUES ('SciFi')");
            Sql("INSERT INTO Genres (Name) VALUES ('Documental')");
            Sql("INSERT INTO Genres (Name) VALUES ('Anime')");
            Sql("INSERT INTO Genres (Name) VALUES ('Gore')");
            Sql("INSERT INTO Genres (Name) VALUES ('Cosmic Horror')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romantic Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
