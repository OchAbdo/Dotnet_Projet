using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "projetId",
                table: "taches",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_taches_projetId",
                table: "taches",
                column: "projetId");

            migrationBuilder.AddForeignKey(
                name: "FK_taches_projet_projetId",
                table: "taches",
                column: "projetId",
                principalTable: "projet",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_taches_projet_projetId",
                table: "taches");

            migrationBuilder.DropIndex(
                name: "IX_taches_projetId",
                table: "taches");

            migrationBuilder.DropColumn(
                name: "projetId",
                table: "taches");
        }
    }
}
