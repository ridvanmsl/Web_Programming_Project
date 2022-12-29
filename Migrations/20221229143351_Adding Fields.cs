using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddingFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ispopular",
                table: "movies",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "isOut",
                table: "movies",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isOut",
                table: "movies");

            migrationBuilder.AlterColumn<bool>(
                name: "ispopular",
                table: "movies",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }
    }
}
