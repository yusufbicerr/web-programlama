using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje2.Migrations
{
    public partial class Zek3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaKalems_Faturalars_FaturalarFaturaid",
                table: "FaturaKalems");

            migrationBuilder.RenameColumn(
                name: "Faturaid",
                table: "Faturalars",
                newName: "Faturalarid");

            migrationBuilder.RenameColumn(
                name: "FaturalarFaturaid",
                table: "FaturaKalems",
                newName: "Faturalarid");

            migrationBuilder.RenameIndex(
                name: "IX_FaturaKalems_FaturalarFaturaid",
                table: "FaturaKalems",
                newName: "IX_FaturaKalems_Faturalarid");

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaKalems_Faturalars_Faturalarid",
                table: "FaturaKalems",
                column: "Faturalarid",
                principalTable: "Faturalars",
                principalColumn: "Faturalarid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaKalems_Faturalars_Faturalarid",
                table: "FaturaKalems");

            migrationBuilder.RenameColumn(
                name: "Faturalarid",
                table: "Faturalars",
                newName: "Faturaid");

            migrationBuilder.RenameColumn(
                name: "Faturalarid",
                table: "FaturaKalems",
                newName: "FaturalarFaturaid");

            migrationBuilder.RenameIndex(
                name: "IX_FaturaKalems_Faturalarid",
                table: "FaturaKalems",
                newName: "IX_FaturaKalems_FaturalarFaturaid");

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaKalems_Faturalars_FaturalarFaturaid",
                table: "FaturaKalems",
                column: "FaturalarFaturaid",
                principalTable: "Faturalars",
                principalColumn: "Faturaid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
