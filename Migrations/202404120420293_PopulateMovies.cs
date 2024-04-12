namespace VidlyApp.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 1, '06/05/2009', '04/11/2024', 4)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 2, '07/22/1988', '04/10/2024', 10)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 2, '10/29/1984', '04/07/2024', 2)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 3, '11/22/1995', '04/09/2024', 6)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 4, '12/19/1997', '04/08/2024', 1)");
        }

        public override void Down()
        {
        }
    }
}
