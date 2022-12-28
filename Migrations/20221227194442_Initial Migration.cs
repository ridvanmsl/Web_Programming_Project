using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAssignment.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imdb = table.Column<double>(type: "float", nullable: true),
                    bigmovimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lilmovimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duration = table.Column<int>(type: "int", nullable: true),
                    trailerLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor1img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor1url = table.Column<string>(name: "actor1_url", type: "nvarchar(max)", nullable: true),
                    actor2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor2img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor2url = table.Column<string>(name: "actor2_url", type: "nvarchar(max)", nullable: true),
                    actor3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor3img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor3url = table.Column<string>(name: "actor3_url", type: "nvarchar(max)", nullable: true),
                    actor4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor4img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor4url = table.Column<string>(name: "actor4_url", type: "nvarchar(max)", nullable: true),
                    actor5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor5img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actor5url = table.Column<string>(name: "actor5_url", type: "nvarchar(max)", nullable: true),
                    ispopular = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
