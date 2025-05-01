using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet.Migrations
{
    /// <inheritdoc />
    public partial class migration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "departement",
                table: "utilisateurs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "utilisateurs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "utilisateurId",
                table: "affectations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_affectations_utilisateurId",
                table: "affectations",
                column: "utilisateurId");

            migrationBuilder.AddForeignKey(
                name: "FK_affectations_utilisateurs_utilisateurId",
                table: "affectations",
                column: "utilisateurId",
                principalTable: "utilisateurs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_affectations_utilisateurs_utilisateurId",
                table: "affectations");

            migrationBuilder.DropIndex(
                name: "IX_affectations_utilisateurId",
                table: "affectations");

            migrationBuilder.DropColumn(
                name: "departement",
                table: "utilisateurs");

            migrationBuilder.DropColumn(
                name: "password",
                table: "utilisateurs");

            migrationBuilder.DropColumn(
                name: "utilisateurId",
                table: "affectations");
        }
    }
}
