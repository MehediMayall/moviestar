using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moviestar.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPIrelationshipincharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Characters_CreatedByID",
                table: "Characters",
                column: "CreatedByID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Users_CreatedByID",
                table: "Characters",
                column: "CreatedByID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Users_CreatedByID",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CreatedByID",
                table: "Characters");
        }
    }
}
