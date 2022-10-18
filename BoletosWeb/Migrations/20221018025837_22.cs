using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class _22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Financeiro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdConta = table.Column<int>(type: "int", nullable: false),
                    IdImovel = table.Column<int>(type: "int", nullable: false),
                    IdPessoaMorador = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesReferencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Pago = table.Column<bool>(type: "bit", nullable: false),
                    ValorPago = table.Column<double>(type: "float", nullable: false),
                    ValorExtra = table.Column<double>(type: "float", nullable: false),
                    ValorDevido = table.Column<double>(type: "float", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financeiro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Financeiro");
        }
    }
}
