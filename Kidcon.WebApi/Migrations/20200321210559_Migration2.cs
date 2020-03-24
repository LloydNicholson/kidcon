using Microsoft.EntityFrameworkCore.Migrations;

namespace Kidcon.WebApi.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "Names",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Names",
                table: "Names",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Names",
                table: "Names");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Names");
        }
    }
}
