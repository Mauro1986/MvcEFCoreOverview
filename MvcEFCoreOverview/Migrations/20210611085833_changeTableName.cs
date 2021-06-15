using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcEFCoreOverview.Migrations
{
    public partial class changeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "tbl_Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Books",
                table: "tbl_Books",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Books",
                table: "tbl_Books");

            migrationBuilder.RenameTable(
                name: "tbl_Books",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "ID");
        }
    }
}
