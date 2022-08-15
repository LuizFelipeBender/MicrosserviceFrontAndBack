using Microsoft.EntityFrameworkCore.Migrations;

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductEntities",
                table: "ProductEntities");

            migrationBuilder.RenameTable(
                name: "ProductEntities",
                newName: "Product_Entities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product_Entities",
                table: "Product_Entities",
                column: "id");

            migrationBuilder.InsertData(
                table: "Product_Entities",
                columns: new[] { "id", "Category_Name", "Description", "Product", "Price", "Image_Url" },
                values: new object[] { 17ul, "Cakes", "Description", "Chocolate Cake", 21.17m, "https://img.elo7.com.br/product/zoom/2A2D7C9/bolo-de-kit-kat-15-anos.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Product_Entities",
                table: "Product_Entities");

            migrationBuilder.DeleteData(
                table: "Product_Entities",
                keyColumn: "id",
                keyValue: 17ul);

            migrationBuilder.RenameTable(
                name: "Product_Entities",
                newName: "ProductEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductEntities",
                table: "ProductEntities",
                column: "id");
        }
    }
}
