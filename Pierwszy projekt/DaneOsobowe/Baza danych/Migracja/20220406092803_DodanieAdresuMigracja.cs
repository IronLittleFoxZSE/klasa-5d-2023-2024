using Microsoft.EntityFrameworkCore.Migrations;

namespace DaneOsobowe.Bazadanych.Migracja
{
    public partial class DodanieAdresuMigracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdresId",
                table: "Osoby",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adresy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ulica = table.Column<string>(nullable: true),
                    NrDomu = table.Column<string>(nullable: true),
                    Miasto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresy", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Osoby_AdresId",
                table: "Osoby",
                column: "AdresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Osoby_Adresy_AdresId",
                table: "Osoby",
                column: "AdresId",
                principalTable: "Adresy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Osoby_Adresy_AdresId",
                table: "Osoby");

            migrationBuilder.DropTable(
                name: "Adresy");

            migrationBuilder.DropIndex(
                name: "IX_Osoby_AdresId",
                table: "Osoby");

            migrationBuilder.DropColumn(
                name: "AdresId",
                table: "Osoby");
        }
    }
}
