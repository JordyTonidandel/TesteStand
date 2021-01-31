using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteStand.Migrations
{
    public partial class ClienteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Razao_social = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true),
                    Data_fundacao = table.Column<DateTime>(nullable: false),
                    Capital = table.Column<double>(nullable: false),
                    Quarentena = table.Column<bool>(nullable: false),
                    Status_cliente = table.Column<bool>(nullable: false),
                    Classificacao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Cnpj",
                table: "Cliente",
                column: "Cnpj",
                unique: true,
                filter: "[Cnpj] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Razao_social",
                table: "Cliente",
                column: "Razao_social",
                unique: true,
                filter: "[Razao_social] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
