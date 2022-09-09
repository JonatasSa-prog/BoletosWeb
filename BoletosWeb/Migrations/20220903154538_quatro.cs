using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class quatro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
