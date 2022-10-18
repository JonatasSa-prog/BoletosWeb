using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class _23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vencimento",
                table: "Financeiro",
                newName: "DataVencimento");

            migrationBuilder.RenameColumn(
                name: "MesReferencia",
                table: "Financeiro",
                newName: "DataReferencia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataVencimento",
                table: "Financeiro",
                newName: "Vencimento");

            migrationBuilder.RenameColumn(
                name: "DataReferencia",
                table: "Financeiro",
                newName: "MesReferencia");
        }
    }
}
