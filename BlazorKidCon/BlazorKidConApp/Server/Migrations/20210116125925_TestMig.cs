using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorKidConApp.Server.Migrations
{
    public partial class TestMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 9L, "New Item Supplier", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 9L);
        }
    }
}
