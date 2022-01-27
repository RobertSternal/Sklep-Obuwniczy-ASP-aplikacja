using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektSklep.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producenci",
                columns: table => new
                {
                    ProducentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazwaProducenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producenci", x => x.ProducentId);
                });

            migrationBuilder.CreateTable(
                name: "Buty",
                columns: table => new
                {
                    ButId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<double>(type: "float", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kategoriaButa = table.Column<int>(type: "int", nullable: false),
                    ProducentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buty", x => x.ButId);
                    table.ForeignKey(
                        name: "FK_Buty_Producenci_ProducentId",
                        column: x => x.ProducentId,
                        principalTable: "Producenci",
                        principalColumn: "ProducentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kolorystyki",
                columns: table => new
                {
                    KolorystykaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kolorystyki", x => x.KolorystykaId);
                    table.ForeignKey(
                        name: "FK_Kolorystyki_Buty_ButId",
                        column: x => x.ButId,
                        principalTable: "Buty",
                        principalColumn: "ButId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buty_ProducentId",
                table: "Buty",
                column: "ProducentId");

            migrationBuilder.CreateIndex(
                name: "IX_Kolorystyki_ButId",
                table: "Kolorystyki",
                column: "ButId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kolorystyki");

            migrationBuilder.DropTable(
                name: "Buty");

            migrationBuilder.DropTable(
                name: "Producenci");
        }
    }
}
