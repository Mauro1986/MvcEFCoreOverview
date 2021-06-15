using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcEFCoreOverview.Migrations
{
    public partial class EdditColumnNameNotationForYearPublished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearPublished",
                table: "Books",
                newName: "Published");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Published",
                table: "Books",
                newName: "YearPublished");
        }
    }
}
