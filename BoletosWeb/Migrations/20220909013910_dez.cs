using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class dez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Pessoa_PessoaId",
                table: "Telefone");

            migrationBuilder.DropIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Telefone");

            migrationBuilder.AddColumn<int>(
                name: "TelefoneId",
                table: "Pessoa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_TelefoneId",
                table: "Pessoa",
                column: "TelefoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Telefone_TelefoneId",
                table: "Pessoa",
                column: "TelefoneId",
                principalTable: "Telefone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Telefone_TelefoneId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_TelefoneId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "Pessoa");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Telefone",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefone",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Pessoa_PessoaId",
                table: "Telefone",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
