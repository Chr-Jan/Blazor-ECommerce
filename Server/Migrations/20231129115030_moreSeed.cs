using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorECommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class moreSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 2, 3, 10.99m, 3.99m },
                    { 2, 4, 11.99m, 2.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 4 });
        }
    }
}
