using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcEFCoreOverview.Migrations
{
    public partial class TableBookDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //EIGEN CODE VOOR UPDATE OM BACK UP/COPY TE MAKEN
            migrationBuilder.Sql("Select * Into COPY_Books From Books");
           
            migrationBuilder.DropTable(
                name: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Counters = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsBestSeller = table.Column<bool>(type: "bit", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    YearPublished = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });

            //EIGEN CODE VOOR UPDATE OM BACK UP/COPY TE MAKEN
            migrationBuilder.Sql("Insert Into Books select Author, Counters, Genre, IsBestSeller, Pages, Title, YearPublished From COPY_Books");

        }
    }
}
