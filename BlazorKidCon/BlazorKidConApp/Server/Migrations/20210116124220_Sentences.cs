using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorKidConApp.Server.Migrations
{
    public partial class Sentences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Names",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Names", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    IncreasingSide = table.Column<string>(type: "TEXT", nullable: true),
                    ClassificationId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Classifications_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "Classifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alternatives",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AlternativePhrase = table.Column<string>(type: "TEXT", nullable: true),
                    AlternativeName = table.Column<string>(type: "TEXT", nullable: true),
                    AccountId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alternatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alternatives_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sentences",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusinessId = table.Column<long>(type: "INTEGER", nullable: false),
                    BusinessName = table.Column<string>(type: "TEXT", nullable: true),
                    OwnerId = table.Column<long>(type: "INTEGER", nullable: true),
                    OtherPartyId = table.Column<long>(type: "INTEGER", nullable: true),
                    AccountId = table.Column<long>(type: "INTEGER", nullable: true),
                    TransactionPhrase = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionAmount = table.Column<float>(type: "REAL", nullable: false),
                    Method = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sentences_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sentences_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sentences_Names_OtherPartyId",
                        column: x => x.OtherPartyId,
                        principalTable: "Names",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sentences_Names_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Names",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ClassificationId",
                table: "Accounts",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Alternatives_AccountId",
                table: "Alternatives",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentences_AccountId",
                table: "Sentences",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentences_BusinessId",
                table: "Sentences",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentences_OtherPartyId",
                table: "Sentences",
                column: "OtherPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentences_OwnerId",
                table: "Sentences",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alternatives");

            migrationBuilder.DropTable(
                name: "Sentences");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Names");

            migrationBuilder.DropTable(
                name: "Classifications");
        }
    }
}
