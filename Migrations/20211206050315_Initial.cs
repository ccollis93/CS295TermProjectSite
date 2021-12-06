using Microsoft.EntityFrameworkCore.Migrations;

namespace GameBaseSite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserGameId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EsrbRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRating = table.Column<int>(type: "int", nullable: false),
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Completed", "EsrbRating", "Genre", "Title", "UserGameId", "UserRating" },
                values: new object[] { 1, true, "E", "Epic", "Secret Test Game", 0, 10 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Completed", "EsrbRating", "Genre", "Title", "UserGameId", "UserRating" },
                values: new object[] { 2, false, "M", "Heinous", "Secret Test Game 2", 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
