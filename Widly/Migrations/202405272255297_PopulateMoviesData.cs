namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Shrek', 'Comedy', '05/18/2001', '12/20/2010', 10)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Shrek 2', 'Documental', '05/19/2004', '12/22/2010', 9)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Shrek The Third', 'Terror', '05/18/2007', '12/24/2010', 8)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Shrek Forever after', 'Suspense', '05/21/2010', '12/26/2010', 7)");

        }

        public override void Down()
        {
        }
    }
}
