using Microsoft.EntityFrameworkCore.Migrations;

namespace MBLibraryWeb.DB.Migrations
{
    public partial class ColumnDOBrename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Users",
                newName: "DateOfBirth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Users",
                newName: "DOB");
        }
    }
}
