using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAssignment.Migrations.news
{
    /// <inheritdoc />
    public partial class AddingNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "news",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    newsdate = table.Column<string>(name: "news_date", type: "nvarchar(max)", nullable: true),
                    newscategory = table.Column<string>(name: "news_category", type: "nvarchar(max)", nullable: true),
                    newsimg = table.Column<string>(name: "news_img", type: "nvarchar(max)", nullable: true),
                    newstext = table.Column<string>(name: "news_text", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "news");
        }
    }
}
