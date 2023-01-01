using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje2.Migrations
{
    public partial class Zek2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Carilers_CarilerCariID",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_CarilerCariID",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "CarilerCariID",
                table: "SatisHarekets");

            migrationBuilder.RenameColumn(
                name: "CariID",
                table: "SatisHarekets",
                newName: "CarilerID");

            migrationBuilder.RenameColumn(
                name: "CariID",
                table: "Carilers",
                newName: "CarilerID");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_CarilerID",
                table: "SatisHarekets",
                column: "CarilerID");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Carilers_CarilerID",
                table: "SatisHarekets",
                column: "CarilerID",
                principalTable: "Carilers",
                principalColumn: "CarilerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Carilers_CarilerID",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_CarilerID",
                table: "SatisHarekets");

            migrationBuilder.RenameColumn(
                name: "CarilerID",
                table: "SatisHarekets",
                newName: "CariID");

            migrationBuilder.RenameColumn(
                name: "CarilerID",
                table: "Carilers",
                newName: "CariID");

            migrationBuilder.AddColumn<int>(
                name: "CarilerCariID",
                table: "SatisHarekets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_CarilerCariID",
                table: "SatisHarekets",
                column: "CarilerCariID");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Carilers_CarilerCariID",
                table: "SatisHarekets",
                column: "CarilerCariID",
                principalTable: "Carilers",
                principalColumn: "CariID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
