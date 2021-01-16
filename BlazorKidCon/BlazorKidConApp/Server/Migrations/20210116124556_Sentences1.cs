using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorKidConApp.Server.Migrations
{
    public partial class Sentences1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 8L);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 1L, "Builder", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 2L, "Plumber", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 3L, "Electrician", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 4L, "Accountant", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 5L, "Painter", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 6L, "Gardener", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 7L, "Dancer", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 8L, "Art Supplier", 1 });

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
    }
}
