using Microsoft.EntityFrameworkCore.Migrations;

namespace safari.Migrations
{
    public partial class moreseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SafariVacation",
                columns: new[] { "Id", "CountOfTimesSeen", "LocationOfLastSeen", "Species" },
                values: new object[] { -2, 2, "Serengeti", "Lelephant" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SafariVacation",
                keyColumn: "Id",
                keyValue: -2);
        }
    }
}
