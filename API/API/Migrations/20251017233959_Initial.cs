using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Levantamento",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataLevantamento = table.Column<string>(type: "TEXT", nullable: false),
                    CarneVendida = table.Column<int>(type: "INTEGER", nullable: false),
                    FranbaconVendido = table.Column<int>(type: "INTEGER", nullable: false),
                    LinguicaVendida = table.Column<int>(type: "INTEGER", nullable: false),
                    Carvao = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecoCarvao = table.Column<decimal>(type: "TEXT", nullable: false),
                    QntCarneDespesa = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecoCarneDespesa = table.Column<decimal>(type: "TEXT", nullable: false),
                    QntFranbaconDespesa = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecoFranbaconDespesa = table.Column<decimal>(type: "TEXT", nullable: false),
                    QntLinguicaDespesa = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecoLinguicaDespesa = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levantamento", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Levantamento");
        }
    }
}
