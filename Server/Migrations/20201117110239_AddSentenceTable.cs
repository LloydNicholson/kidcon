using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientApp.Server.Migrations
{
    public partial class AddSentenceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sentence",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusinessId = table.Column<long>(type: "INTEGER", nullable: true),
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
                    table.PrimaryKey("PK_Sentence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sentence_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sentence_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sentence_Names_OtherPartyId",
                        column: x => x.OtherPartyId,
                        principalTable: "Names",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sentence_Names_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Names",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_AccountId",
                table: "Sentence",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_BusinessId",
                table: "Sentence",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_OtherPartyId",
                table: "Sentence",
                column: "OtherPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_OwnerId",
                table: "Sentence",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sentence");
        }
    }
}
