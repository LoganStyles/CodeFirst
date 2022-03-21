using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    public partial class AddedCommonDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_Publishers",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "tbl_Publishers",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "tbl_Publishers",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_Publishers",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");
        }
    }
}
