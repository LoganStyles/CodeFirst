using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    public partial class ResetMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeniorityLevels",
                columns: table =>
                    new
                    {
                        Id = table
                            .Column<long>(type: "INTEGER", nullable: false)
                            .Annotation("Sqlite:Autoincrement", true),
                        Title = table.Column<string>(type: "TEXT", nullable: false),
                        Description = table.Column<string>(type: "TEXT", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeniorityLevels", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table =>
                    new
                    {
                        Id = table
                            .Column<long>(type: "INTEGER", nullable: false)
                            .Annotation("Sqlite:Autoincrement", true),
                        Title = table.Column<string>(type: "TEXT", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table =>
                    new
                    {
                        Id = table
                            .Column<long>(type: "INTEGER", nullable: false)
                            .Annotation("Sqlite:Autoincrement", true),
                        FirstName = table.Column<string>(type: "TEXT", nullable: false),
                        LastName = table.Column<string>(type: "TEXT", nullable: false),
                        Age = table.Column<long>(type: "INTEGER", nullable: false),
                        SeniorityLevelId = table.Column<long>(type: "INTEGER", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_SeniorityLevels_SeniorityLevelId",
                        column: x => x.SeniorityLevelId,
                        principalTable: "SeniorityLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table =>
                    new
                    {
                        Id = table
                            .Column<long>(type: "INTEGER", nullable: false)
                            .Annotation("Sqlite:Autoincrement", true),
                        Title = table.Column<string>(type: "TEXT", nullable: false),
                        Price = table.Column<double>(type: "REAL", nullable: false),
                        EmployeeId = table.Column<long>(type: "INTEGER", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table =>
                    new
                    {
                        Id = table
                            .Column<long>(type: "INTEGER", nullable: false)
                            .Annotation("Sqlite:Autoincrement", true),
                        HouseNumber = table.Column<long>(type: "INTEGER", nullable: false),
                        City = table.Column<string>(type: "TEXT", nullable: false),
                        EmployeeId = table.Column<long>(type: "INTEGER", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studios_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "AlbumTags",
                columns: table =>
                    new
                    {
                        AlbumId = table.Column<long>(type: "INTEGER", nullable: false),
                        TagId = table.Column<long>(type: "INTEGER", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumTags", x => new { x.AlbumId, x.TagId });
                    table.ForeignKey(
                        name: "FK_AlbumTags_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_AlbumTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1L, "Rock" }
            );

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2L, "RnB" }
            );

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Title" },
                values: new object[] { 3L, "Jazz" }
            );

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Title" },
                values: new object[] { 4L, "Country" }
            );

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Title" },
                values: new object[] { 5L, "Classical" }
            );

            migrationBuilder.CreateIndex(
                name: "IX_Albums_EmployeeId",
                table: "Albums",
                column: "EmployeeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_AlbumTags_TagId",
                table: "AlbumTags",
                column: "TagId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SeniorityLevelId",
                table: "Employees",
                column: "SeniorityLevelId",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_Studios_EmployeeId",
                table: "Studios",
                column: "EmployeeId",
                unique: true
            );

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
            migrationBuilder.DropTable(name: "AlbumTags");

            migrationBuilder.DropTable(name: "Studios");

            migrationBuilder.DropTable(name: "Albums");

            migrationBuilder.DropTable(name: "Tags");

            migrationBuilder.DropTable(name: "Employees");

            migrationBuilder.DropTable(name: "SeniorityLevels");

            migrationBuilder.Sql("DELETE FROM SeniorityLevels");
        }
    }
}



