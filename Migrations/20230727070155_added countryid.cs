using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moviestar.Migrations
{
    /// <inheritdoc />
    public partial class addedcountryid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Countries_CountryId",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Countries_CountryId",
                table: "Characters",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Countries_CountryId",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Countries_CountryId",
                table: "Characters",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
