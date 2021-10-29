using Microsoft.EntityFrameworkCore.Migrations;

namespace riode.Migrations
{
    public partial class CategoryBigCategoryIdColAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BigCategoryId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BigCategoryId",
                table: "Category");
        }
    }
}
