using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class DeleteNullBrandCategoryIdFromProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandCategories_BrandCategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "BrandCategoryId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandCategories_BrandCategoryId",
                table: "Products",
                column: "BrandCategoryId",
                principalTable: "BrandCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandCategories_BrandCategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "BrandCategoryId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandCategories_BrandCategoryId",
                table: "Products",
                column: "BrandCategoryId",
                principalTable: "BrandCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
