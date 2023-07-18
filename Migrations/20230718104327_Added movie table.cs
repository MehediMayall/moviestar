using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moviestar.Migrations
{
    /// <inheritdoc />
    public partial class Addedmovietable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Characters_CharacterId",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_CharacterId",
                table: "Movies",
                newName: "IX_Movies_CharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Characters_CharacterId",
                table: "Movies",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropForeignKey(
            //     name: "FK_Movies_Characters_CharacterId",
            //     table: "Movies");

            // migrationBuilder.DropPrimaryKey(
            //     name: "PK_Movies",
            //     table: "Movies");

            // migrationBuilder.RenameTable(
            //     name: "Movies",
            //     newName: "Movie");

            // migrationBuilder.RenameIndex(
            //     name: "IX_Movies_CharacterId",
            //     table: "Movie",
            //     newName: "IX_Movie_CharacterId");

            // migrationBuilder.AddPrimaryKey(
            //     name: "PK_Movie",
            //     table: "Movie",
            //     column: "Id");

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Movie_Characters_CharacterId",
            //     table: "Movie",
            //     column: "CharacterId",
            //     principalTable: "Characters",
            //     principalColumn: "Id");
        }
    }
}
