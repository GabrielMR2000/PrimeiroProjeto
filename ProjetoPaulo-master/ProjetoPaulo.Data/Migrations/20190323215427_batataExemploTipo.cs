using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPaulo.Data.Migrations
{
    public partial class batataExemploTipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "tipo_bat_id",
                table: "tb_batata",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "tb_tipo_batata",
                columns: table => new
                {
                    tipo_bat_id = table.Column<Guid>(nullable: false),
                    tipo_bat_descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_tipo_batata", x => x.tipo_bat_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_batata_tipo_bat_id",
                table: "tb_batata",
                column: "tipo_bat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_batata_tb_tipo_batata_tipo_bat_id",
                table: "tb_batata",
                column: "tipo_bat_id",
                principalTable: "tb_tipo_batata",
                principalColumn: "tipo_bat_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_batata_tb_tipo_batata_tipo_bat_id",
                table: "tb_batata");

            migrationBuilder.DropTable(
                name: "tb_tipo_batata");

            migrationBuilder.DropIndex(
                name: "IX_tb_batata_tipo_bat_id",
                table: "tb_batata");

            migrationBuilder.DropColumn(
                name: "tipo_bat_id",
                table: "tb_batata");
        }
    }
}
