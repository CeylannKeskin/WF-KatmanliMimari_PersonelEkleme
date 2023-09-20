using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatmanliMimari_PersonelEkleme2_DAL.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TCKimlikNo = table.Column<string>(type: "char(11)", maxLength: 11, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.PersonelID);
                });

            migrationBuilder.CreateTable(
                name: "IletisimBilgileri",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Telefon = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimBilgileri", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_IletisimBilgileri_Personeller_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personeller",
                        principalColumn: "PersonelID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IletisimBilgileri");

            migrationBuilder.DropTable(
                name: "Personeller");
        }
    }
}
