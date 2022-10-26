using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    public partial class RenameAndDeletePropertiesInDept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HOD",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Departments",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "HOD",
                table: "Departments",
                type: "TEXT",
                nullable: true);
        }
    }
}
