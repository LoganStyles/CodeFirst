using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    public partial class PopulateSeniorityLevelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO SeniorityLevels ([Title],[Description]) VALUES('intern','intership candidates')"
            );
            migrationBuilder.Sql(
                "INSERT INTO SeniorityLevels ([Title],[Description]) VALUES('junior','employees with less than 3 years experience')"
            );
            migrationBuilder.Sql(
                "INSERT INTO SeniorityLevels ([Title],[Description]) VALUES('intermediate','employees with 3 years experience')"
            );
            migrationBuilder.Sql(
                "INSERT INTO SeniorityLevels ([Title],[Description]) VALUES('senior','employees with 5 years experience')"
            );
            migrationBuilder.Sql(
                "INSERT INTO SeniorityLevels ([Title],[Description]) VALUES('principal','employees with 10 years experience')"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM SeniorityLevels");
        }
    }
}



