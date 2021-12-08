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
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EsrbRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "ProfileGames",
                columns: table => new
                {
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EsrbRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileGames", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavoriteGame = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UsrGames",
                columns: table => new
                {
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsrGames", x => new { x.UserId, x.GameId });
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "EsrbRating", "Genre", "Title", "Type" },
                values: new object[,]
                {
                    { "1", "M", "First Person Shooter", "Quake", "Power" },
                    { "2", "M", "Paradox Grand Strategy", "Crusader Kings III", "Brainy" },
                    { "3", "T", "Casino Games", "Vegas Casino Collections", "Casual" },
                    { "4", "E", "2d Platformer", "Waluigi World 2", "OldSchool" },
                    { "5", "M", "Survival Horror", "Escape From Tarkov", "Power" },
                    { "6", "E", "Tower Defense", "Bloons TD -1", "Casual" },
                    { "7", "T", "Adventure Puzzle", "The Initiate", "Brainy" },
                    { "8", "E", "Arcade", "Mr.Peck-Mon", "OldSchool" }
                });

            migrationBuilder.InsertData(
                table: "ProfileGames",
                columns: new[] { "GameId", "EsrbRating", "Genre", "Title", "Type" },
                values: new object[,]
                {
                    { "4", "E", "2d Platformer", "Waluigi World 2", "OldSchool" },
                    { "5", "M", "Survival Horror", "Escape From Tarkov", "Power" },
                    { "2", "M", "Paradox Grand Strategy", "Crusader Kings III", "Brainy" },
                    { "3", "T", "Casino Games", "Vegas Casino Collections", "Casual" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "FavoriteGame", "PlayStyle", "UserName" },
                values: new object[,]
                {
                    { "222", "The Impossible Game", "Brainy", "starchild" },
                    { "111", "PC Building Simulator", "Power", "GameDude01" },
                    { "444", "Asteroids", "OldSchool", "corvetteFan1963" },
                    { "333", "Candy Crush", "Casual", "MomOfThree" }
                });

            migrationBuilder.InsertData(
                table: "UsrGames",
                columns: new[] { "GameId", "UserId", "Title" },
                values: new object[,]
                {
                    { "2", "222", "Crusader Kings III" },
                    { "4", "222", "Waluigi World 2" },
                    { "7", "111", "The Initiate" },
                    { "6", "333", "Bloons TD -1" },
                    { "3", "333", "Vegas Casino Collections" },
                    { "8", "444", "Mr.Peck-Mon" },
                    { "4", "444", "Waluigi World 2" },
                    { "1", "444", "Quake" },
                    { "1", "222", "Quake" },
                    { "5", "111", "Escape From Tarkov" },
                    { "2", "111", "Crusader Kings III" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "ProfileGames");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UsrGames");
        }
    }
}
