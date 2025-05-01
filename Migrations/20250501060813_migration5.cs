using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet.Migrations
{
    /// <inheritdoc />
    public partial class migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "tacheid",
                table: "affectations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_affectations_tacheid",
                table: "affectations",
                column: "tacheid");

            migrationBuilder.AddForeignKey(
                name: "FK_affectations_taches_tacheid",
                table: "affectations",
                column: "tacheid",
                principalTable: "taches",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_affectations_taches_tacheid",
                table: "affectations");

            migrationBuilder.DropIndex(
                name: "IX_affectations_tacheid",
                table: "affectations");

            migrationBuilder.DropColumn(
                name: "tacheid",
                table: "affectations");
        }
    }
}
