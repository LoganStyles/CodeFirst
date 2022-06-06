using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    public partial class AddedSeniorityLevelIdPropToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SeniorityLevelId",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SeniorityLevelId",
                table: "Employees",
                column: "SeniorityLevelId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SeniorityLevels_SeniorityLevelId",
                table: "Employees",
                column: "SeniorityLevelId",
                principalTable: "SeniorityLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SeniorityLevels_SeniorityLevelId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SeniorityLevelId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SeniorityLevelId",
                table: "Employees");
        }
    }
}



