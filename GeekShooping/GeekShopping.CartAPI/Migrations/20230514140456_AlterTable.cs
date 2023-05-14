using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.CartAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cart_detail_cart_header_cart_header_id",
                table: "cart_detail");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_detail_product_product_id",
                table: "cart_detail");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "cart_detail",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "cart_header_id",
                table: "cart_detail",
                newName: "CartHeaderId");

            migrationBuilder.RenameIndex(
                name: "IX_cart_detail_product_id",
                table: "cart_detail",
                newName: "IX_cart_detail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_cart_detail_cart_header_id",
                table: "cart_detail",
                newName: "IX_cart_detail_CartHeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_cart_detail_cart_header_CartHeaderId",
                table: "cart_detail",
                column: "CartHeaderId",
                principalTable: "cart_header",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cart_detail_product_ProductId",
                table: "cart_detail",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cart_detail_cart_header_CartHeaderId",
                table: "cart_detail");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_detail_product_ProductId",
                table: "cart_detail");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "cart_detail",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "CartHeaderId",
                table: "cart_detail",
                newName: "cart_header_id");

            migrationBuilder.RenameIndex(
                name: "IX_cart_detail_ProductId",
                table: "cart_detail",
                newName: "IX_cart_detail_product_id");

            migrationBuilder.RenameIndex(
                name: "IX_cart_detail_CartHeaderId",
                table: "cart_detail",
                newName: "IX_cart_detail_cart_header_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cart_detail_cart_header_cart_header_id",
                table: "cart_detail",
                column: "cart_header_id",
                principalTable: "cart_header",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cart_detail_product_product_id",
                table: "cart_detail",
                column: "product_id",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
