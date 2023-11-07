using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BásicoFacil.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Data",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    agua_potavel = table.Column<bool>(type: "bit", nullable: false),
                    rede_esgoto = table.Column<bool>(type: "bit", nullable: false),
                    drenagem = table.Column<bool>(type: "bit", nullable: false),
                    coleta_lixo = table.Column<bool>(type: "bit", nullable: false),
                    pontos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Data");
        }
    }
}
