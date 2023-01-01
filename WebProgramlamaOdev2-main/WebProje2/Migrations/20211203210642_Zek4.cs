using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje2.Migrations
{
    public partial class Zek4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaKalems_Faturalars_Faturalarid",
                table: "FaturaKalems");

            migrationBuilder.DropColumn(
                name: "Faturaid",
                table: "FaturaKalems");

            migrationBuilder.AlterColumn<int>(
                name: "Faturalarid",
                table: "FaturaKalems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaKalems_Faturalars_Faturalarid",
                table: "FaturaKalems",
                column: "Faturalarid",
                principalTable: "Faturalars",
                principalColumn: "Faturalarid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaKalems_Faturalars_Faturalarid",
                table: "FaturaKalems");

            migrationBuilder.AlterColumn<int>(
                name: "Faturalarid",
                table: "FaturaKalems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Faturaid",
                table: "FaturaKalems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaKalems_Faturalars_Faturalarid",
                table: "FaturaKalems",
                column: "Faturalarid",
                principalTable: "Faturalars",
                principalColumn: "Faturalarid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
