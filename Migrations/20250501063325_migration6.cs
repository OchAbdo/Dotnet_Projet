using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet.Migrations
{
    /// <inheritdoc />
    public partial class migration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_affectations_taches_tacheid",
                table: "affectations");

            migrationBuilder.RenameColumn(
                name: "tacheid",
                table: "affectations",
                newName: "tacheId");

            migrationBuilder.RenameIndex(
                name: "IX_affectations_tacheid",
                table: "affectations",
                newName: "IX_affectations_tacheId");

            migrationBuilder.AddForeignKey(
                name: "FK_affectations_taches_tacheId",
                table: "affectations",
                column: "tacheId",
                principalTable: "taches",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_affectations_taches_tacheId",
                table: "affectations");

            migrationBuilder.RenameColumn(
                name: "tacheId",
                table: "affectations",
                newName: "tacheid");

            migrationBuilder.RenameIndex(
                name: "IX_affectations_tacheId",
                table: "affectations",
                newName: "IX_affectations_tacheid");

            migrationBuilder.AddForeignKey(
                name: "FK_affectations_taches_tacheid",
                table: "affectations",
                column: "tacheid",
                principalTable: "taches",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
