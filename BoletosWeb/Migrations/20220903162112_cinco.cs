using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class cinco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContaId",
                table: "Pessoa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_ContaId",
                table: "Pessoa",
                column: "ContaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Conta_ContaId",
                table: "Pessoa",
                column: "ContaId",
                principalTable: "Conta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Conta_ContaId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_ContaId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "ContaId",
                table: "Pessoa");
        }
    }
}
