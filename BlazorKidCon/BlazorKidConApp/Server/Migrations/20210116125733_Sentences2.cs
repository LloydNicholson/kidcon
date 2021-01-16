using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorKidConApp.Server.Migrations
{
    public partial class Sentences2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 1L, null, "debit", "Trading stock" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 23L, null, "debit", "Interest on loan" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 24L, null, "debit", "Interest expense" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 25L, null, "debit", "Postage" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 26L, null, "debit", "Donations expense" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 28L, null, "debit", "Cost of Sales" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 29L, null, "credit", "Loan" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 30L, null, "credit", "Mortgage bond" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 31L, null, "credit", "Bank overdraft" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 32L, null, "credit", "Creditors Control" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 33L, null, "credit", "Current income" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 34L, null, "credit", "Rent income" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 35L, null, "credit", "Donations income" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 36L, null, "credit", "Commission" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 37L, null, "credit", "Sales" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 38L, null, "credit", "Interest income" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 39L, null, "credit", "Interest on fixed deposit" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 40L, null, "credit", "Capital" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 22L, null, "debit", "Consumable goods" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 21L, null, "debit", "Bank charges" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 27L, null, "debit", "Rent expense" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 19L, null, "debit", "Packing material" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 2L, null, "debit", "Vehicles" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 3L, null, "debit", "Equipment" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 20L, null, "debit", "Fuel" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 5L, null, "debit", "Land and buildings" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 6L, null, "debit", "Petty Cash" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 7L, null, "debit", "Cash float" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 8L, null, "debit", "Furniture" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 9L, null, "debit", "Bank" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 10L, null, "debit", "Drawings" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 4L, null, "debit", "Machinery" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 12L, null, "debit", "Wages" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 13L, null, "debit", "Repairs" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 14L, null, "debit", "Advertising" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 15L, null, "debit", "Telephone" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 16L, null, "debit", "Stationery" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 17L, null, "debit", "Water and electricity" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 18L, null, "debit", "Insurance" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "ClassificationId", "IncreasingSide", "Name" },
                values: new object[] { 11L, null, "debit", "Salaries" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 8L, "Art Supplier", 1 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 7L, "Dancer", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 6L, "Gardener", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 5L, "Painter", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 3L, "Electrician", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 2L, "Plumber", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 1L, "Builder", 0 });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 4L, "Accountant", 0 });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "Type" },
                values: new object[] { 5L, "Income" });

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
                values: new object[] { 6L, "Liability" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 40L);

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
    }
}
