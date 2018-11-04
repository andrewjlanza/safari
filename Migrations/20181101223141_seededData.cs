using Microsoft.EntityFrameworkCore.Migrations;

namespace safari.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SafariVacation",
                columns: new[] { "Id", "CountOfTimesSeen", "LocationOfLastSeen", "Species" },
                values: new object[] { -1, 3, "watering hole", "Hyena" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SafariVacation",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
