using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet.Migrations
{
    /// <inheritdoc />
    public partial class migrations8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "rapports",
                newName: "continu");

            migrationBuilder.AddColumn<long>(
                name: "projetId",
                table: "rapports",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "utilisateurId",
                table: "rapports",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_rapports_projetId",
                table: "rapports",
                column: "projetId");

            migrationBuilder.CreateIndex(
                name: "IX_rapports_utilisateurId",
                table: "rapports",
                column: "utilisateurId");

            migrationBuilder.AddForeignKey(
                name: "FK_rapports_projet_projetId",
                table: "rapports",
                column: "projetId",
                principalTable: "projet",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rapports_utilisateurs_utilisateurId",
                table: "rapports",
                column: "utilisateurId",
                principalTable: "utilisateurs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rapports_projet_projetId",
                table: "rapports");

            migrationBuilder.DropForeignKey(
                name: "FK_rapports_utilisateurs_utilisateurId",
                table: "rapports");

            migrationBuilder.DropIndex(
                name: "IX_rapports_projetId",
                table: "rapports");

            migrationBuilder.DropIndex(
                name: "IX_rapports_utilisateurId",
                table: "rapports");

            migrationBuilder.DropColumn(
                name: "projetId",
                table: "rapports");

            migrationBuilder.DropColumn(
                name: "utilisateurId",
                table: "rapports");

            migrationBuilder.RenameColumn(
                name: "continu",
                table: "rapports",
                newName: "description");
        }
    }
}
