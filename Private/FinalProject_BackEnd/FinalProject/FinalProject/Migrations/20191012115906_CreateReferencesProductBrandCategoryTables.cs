using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class CreateReferencesProductBrandCategoryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandCategory_Brands_BrandId",
                table: "BrandCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BrandCategory_Categories_CategorieId",
                table: "BrandCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrandCategory",
                table: "BrandCategory");

            migrationBuilder.RenameTable(
                name: "BrandCategory",
                newName: "BrandCategories");

            migrationBuilder.RenameIndex(
                name: "IX_BrandCategory_CategorieId",
                table: "BrandCategories",
                newName: "IX_BrandCategories_CategorieId");

            migrationBuilder.RenameIndex(
                name: "IX_BrandCategory_BrandId",
                table: "BrandCategories",
                newName: "IX_BrandCategories_BrandId");

            migrationBuilder.AddColumn<int>(
                name: "BrandCategoryId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrandCategories",
                table: "BrandCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandCategoryId",
                table: "Products",
                column: "BrandCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrandCategories_Brands_BrandId",
                table: "BrandCategories",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BrandCategories_Categories_CategorieId",
                table: "BrandCategories",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandCategories_BrandCategoryId",
                table: "Products",
                column: "BrandCategoryId",
                principalTable: "BrandCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandCategories_Brands_BrandId",
                table: "BrandCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BrandCategories_Categories_CategorieId",
                table: "BrandCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandCategories_BrandCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BrandCategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrandCategories",
                table: "BrandCategories");

            migrationBuilder.DropColumn(
                name: "BrandCategoryId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "BrandCategories",
                newName: "BrandCategory");

            migrationBuilder.RenameIndex(
                name: "IX_BrandCategories_CategorieId",
                table: "BrandCategory",
                newName: "IX_BrandCategory_CategorieId");

            migrationBuilder.RenameIndex(
                name: "IX_BrandCategories_BrandId",
                table: "BrandCategory",
                newName: "IX_BrandCategory_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrandCategory",
                table: "BrandCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BrandCategory_Brands_BrandId",
                table: "BrandCategory",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BrandCategory_Categories_CategorieId",
                table: "BrandCategory",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
