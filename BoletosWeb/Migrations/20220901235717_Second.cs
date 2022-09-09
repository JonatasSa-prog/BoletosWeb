using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imovel_Pessoa_IdMoradorId",
                table: "Imovel");

            migrationBuilder.DropForeignKey(
                name: "FK_Imovel_Pessoa_IdProprietarioId",
                table: "Imovel");

            migrationBuilder.RenameColumn(
                name: "IdProprietarioId",
                table: "Imovel",
                newName: "ProprietarioId");

            migrationBuilder.RenameColumn(
                name: "IdMoradorId",
                table: "Imovel",
                newName: "MoradorId");

            migrationBuilder.RenameIndex(
                name: "IX_Imovel_IdProprietarioId",
                table: "Imovel",
                newName: "IX_Imovel_ProprietarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Imovel_IdMoradorId",
                table: "Imovel",
                newName: "IX_Imovel_MoradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imovel_Pessoa_MoradorId",
                table: "Imovel",
                column: "MoradorId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Imovel_Pessoa_ProprietarioId",
                table: "Imovel",
                column: "ProprietarioId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imovel_Pessoa_MoradorId",
                table: "Imovel");

            migrationBuilder.DropForeignKey(
                name: "FK_Imovel_Pessoa_ProprietarioId",
                table: "Imovel");

            migrationBuilder.RenameColumn(
                name: "ProprietarioId",
                table: "Imovel",
                newName: "IdProprietarioId");

            migrationBuilder.RenameColumn(
                name: "MoradorId",
                table: "Imovel",
                newName: "IdMoradorId");

            migrationBuilder.RenameIndex(
                name: "IX_Imovel_ProprietarioId",
                table: "Imovel",
                newName: "IX_Imovel_IdProprietarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Imovel_MoradorId",
                table: "Imovel",
                newName: "IX_Imovel_IdMoradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imovel_Pessoa_IdMoradorId",
                table: "Imovel",
                column: "IdMoradorId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Imovel_Pessoa_IdProprietarioId",
                table: "Imovel",
                column: "IdProprietarioId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
