using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class oito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Conta",
                table: "Pessoa",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conta",
                table: "Pessoa");

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
    }
}
