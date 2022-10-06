using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace YeminusSoftware.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Code = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PriceList = table.Column<string>(type: "text", nullable: true),
                    ImgUrl = table.Column<string>(type: "text", nullable: true),
                    ForSale = table.Column<bool>(type: "boolean", nullable: true),
                    Vat = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Code);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Code", "Description", "ForSale", "ImgUrl", "PriceList", "Vat" },
                values: new object[,]
                {
                    { 1, "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops", true, "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", "[]", 19 },
                    { 2, "Mens Casual Premium Slim Fit T-Shirts", true, "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", "[]", 19 },
                    { 3, "Mens Cotton Jacket", true, "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg", "[5000]", 19 },
                    { 4, "Mens Casual Slim Fit", true, "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg", "[50000]", 19 },
                    { 5, "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet", true, "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg", "[50400]", 19 },
                    { 6, "Solid Gold Petite Micropave", true, "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg", "[4500]", 19 },
                    { 7, "White Gold Plated Princess", true, "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg", "[95000]", 19 },
                    { 8, "Pierced Owl Rose Gold Plated Stainless Steel Double", true, "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg", "[36800]", 19 },
                    { 9, "WD 2TB Elements Portable External Hard Drive - USB 3.0", true, "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg", "[89000]", 19 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
