using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje2.Migrations
{
    public partial class ZekKargo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KargoDetays",
                columns: table => new
                {
                    KargoDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "Varchar(300)", maxLength: 300, nullable: true),
                    TakipKodu = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: true),
                    Personel = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Alici = table.Column<string>(type: "Varchar(25)", maxLength: 25, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoDetays", x => x.KargoDetayID);
                });

            migrationBuilder.CreateTable(
                name: "KargoTakips",
                columns: table => new
                {
                    KargoTakipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakipKodu = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: true),
                    Aciklama = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    TarihZaman = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoTakips", x => x.KargoTakipID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KargoDetays");

            migrationBuilder.DropTable(
                name: "KargoTakips");
        }
    }
}
