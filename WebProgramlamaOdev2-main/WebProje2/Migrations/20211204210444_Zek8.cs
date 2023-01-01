using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje2.Migrations
{
    public partial class Zek8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sifre",
                table: "Carilers",
                type: "Varchar(20)",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sifre",
                table: "Carilers");
        }
    }
}
