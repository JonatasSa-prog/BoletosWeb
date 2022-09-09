using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class seis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imovel_Conta_ContaId",
                table: "Imovel");

            migrationBuilder.DropIndex(
                name: "IX_Imovel_ContaId",
                table: "Imovel");

            migrationBuilder.DropColumn(
                name: "ContaId",
                table: "Imovel");

            migrationBuilder.AddColumn<int>(
                name: "Conta",
                table: "Imovel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conta",
                table: "Imovel");

            migrationBuilder.AddColumn<int>(
                name: "ContaId",
                table: "Imovel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_ContaId",
                table: "Imovel",
                column: "ContaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imovel_Conta_ContaId",
                table: "Imovel",
                column: "ContaId",
                principalTable: "Conta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
