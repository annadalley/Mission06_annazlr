using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_annazlr.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Category = table.Column<string>(nullable: false),
                    MovieTitle = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Category);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Category", "Director", "Edited", "LentTo", "MovieTitle", "Notes", "Rating", "Year" },
                values: new object[] { "Action/Adventure", "Anthony Russo", false, "", "The Avengers", "", "PG-13", 2012 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Category", "Director", "Edited", "LentTo", "MovieTitle", "Notes", "Rating", "Year" },
                values: new object[] { "Rom Com", "Garry Marshall", false, "", "The Princess Diaries", "", "G", 2001 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Category", "Director", "Edited", "LentTo", "MovieTitle", "Notes", "Rating", "Year" },
                values: new object[] { "Comedy", "Jared Hess", false, "", "Nacho Libre", "", "PG", 2006 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
