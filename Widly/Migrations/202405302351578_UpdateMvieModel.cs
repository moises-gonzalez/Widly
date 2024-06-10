namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMvieModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Movies", "Genre");
            DropColumn("dbo.Movies", "MovieGenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieGenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
