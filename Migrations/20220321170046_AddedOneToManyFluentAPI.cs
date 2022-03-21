using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    public partial class AddedOneToManyFluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SalesOutletId",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SalesOutletId",
                table: "Orders",
                column: "SalesOutletId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_tbl_SalesOutlets_SalesOutletId",
                table: "Orders",
                column: "SalesOutletId",
                principalTable: "tbl_SalesOutlets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_tbl_SalesOutlets_SalesOutletId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SalesOutletId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SalesOutletId",
                table: "Orders");
        }
    }
}
