using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPaulo.Data.Migrations
{
    public partial class batataExemplo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_batata",
                columns: table => new
                {
                    bat_id = table.Column<Guid>(nullable: false),
                    bat_descricao = table.Column<string>(nullable: false),
                    bat_cor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_batata", x => x.bat_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_batata");
        }
    }
}
