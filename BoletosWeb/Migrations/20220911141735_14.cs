using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class _14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Conta",
                table: "Endereco",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conta",
                table: "Endereco");
        }
    }
}
