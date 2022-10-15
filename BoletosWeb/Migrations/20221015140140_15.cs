using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletosWeb.Migrations
{
    public partial class _15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conta = table.Column<int>(type: "int", nullable: false),
                    codGaragem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImovelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Garagem_Imovel_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Garagem_ImovelId",
                table: "Garagem",
                column: "ImovelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garagem");
        }
    }
}
