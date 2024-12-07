using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientApp.Server.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1L, "Asset" });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "Type" },
                values: new object[] { 2L, "Expense" });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "Type" },
                values: new object[] { 3L, "Drawings" });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "Type" },
                values: new object[] { 4L, "Capital" });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "Type" },
                values: new object[] { 5L, "Income" });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "Type" },
                values: new object[] { 6L, "Liability" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "Id",
                keyValue: 6L);
        }
    }
}
