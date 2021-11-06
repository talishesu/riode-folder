using Microsoft.EntityFrameworkCore.Migrations;

namespace riode.Migrations
{
    public partial class ChangedCatgeories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BigCategory",
                table: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_Category_BigCategoryId",
                table: "Category",
                column: "BigCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_BigCategoryId",
                table: "Category",
                column: "BigCategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_BigCategoryId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_BigCategoryId",
                table: "Category");

            migrationBuilder.AddColumn<bool>(
                name: "BigCategory",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
