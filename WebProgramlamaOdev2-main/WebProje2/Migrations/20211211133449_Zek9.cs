using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje2.Migrations
{
    public partial class Zek9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mesajlars",
                columns: table => new
                {
                    MesajlarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gonderici = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    Alici = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    Konu = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    Icerik = table.Column<string>(type: "Varchar(2000)", maxLength: 2000, nullable: true),
                    Tarih = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlars", x => x.MesajlarID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesajlars");
        }
    }
}
