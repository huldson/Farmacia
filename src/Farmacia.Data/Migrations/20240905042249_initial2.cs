using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmacia.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agrupador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColunaId = table.Column<int>(type: "int", nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtFimVigencia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Industria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtFimVigencia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabelas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndustriaId = table.Column<int>(type: "int", nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtFimVigencia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabelas_Industria_IndustriaId",
                        column: x => x.IndustriaId,
                        principalTable: "Industria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colunas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false),
                    TabelasId = table.Column<int>(type: "int", nullable: false),
                    DadosId = table.Column<int>(type: "int", nullable: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtFimVigencia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colunas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colunas_Dados_DadosId",
                        column: x => x.DadosId,
                        principalTable: "Dados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Colunas_Tabelas_TabelasId",
                        column: x => x.TabelasId,
                        principalTable: "Tabelas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colunas_DadosId",
                table: "Colunas",
                column: "DadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Colunas_TabelasId",
                table: "Colunas",
                column: "TabelasId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabelas_IndustriaId",
                table: "Tabelas",
                column: "IndustriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colunas");

            migrationBuilder.DropTable(
                name: "Dados");

            migrationBuilder.DropTable(
                name: "Tabelas");

            migrationBuilder.DropTable(
                name: "Industria");
        }
    }
}
