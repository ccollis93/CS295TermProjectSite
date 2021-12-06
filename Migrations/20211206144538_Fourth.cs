using Microsoft.EntityFrameworkCore.Migrations;

namespace GameBaseSite.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Games",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Games",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "EsrbRating", "Genre", "Review", "Status", "Title", "Type" },
                values: new object[] { "M", "First Person Shooter", "", "", "Quake", "Power" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Genre", "Review", "Status", "Title", "Type", "UserRating" },
                values: new object[] { "Paradox Grand Strategy", "", "", "Crusader Kings III", "Brainy", 9 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "EsrbRating", "Genre", "Review", "Status", "Title", "Type", "UserRating" },
                values: new object[,]
                {
                    { 3, "T", "Casino Games", "", "", "Vegas Casino Collections", "Casual", 5 },
                    { 4, "E", "2d Platformer", "", "", "Waluigi World 2", "OldSchool", 10 },
                    { 5, "M", "Survival Horro, First Person Shooter", "", "", "Escape From Tarkov", "Power", 9 },
                    { 6, "E", "Tower Defense", "", "", "Bloons TD -1", "Casual", 7 },
                    { 7, "T", "Adventure Puzzle", "", "", "The Initiate", "Brainy", 6 },
                    { 8, "E", "Arcade", "", "", "Mr.Peck-Mon", "OldSchool", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Review",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "EsrbRating", "Genre", "Title" },
                values: new object[] { "E", "Epic", "Secret Test Game" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Genre", "Title", "UserRating" },
                values: new object[] { "Heinous", "Secret Test Game 2", 1 });
        }
    }
}
