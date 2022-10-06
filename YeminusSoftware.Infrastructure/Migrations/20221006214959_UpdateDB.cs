using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace YeminusSoftware.Infrastructure.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceList",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Encrypts",
                columns: table => new
                {
                    Code = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Phrase = table.Column<string>(type: "text", nullable: false),
                    Key = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encrypts", x => x.Code);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 1,
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 2,
                column: "Price",
                value: 50505);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 3,
                column: "Price",
                value: 10000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 4,
                column: "Price",
                value: 10000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 5,
                column: "Price",
                value: 10000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 6,
                column: "Price",
                value: 10000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 7,
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 8,
                column: "Price",
                value: 10000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 9,
                column: "Price",
                value: 10000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encrypts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "PriceList",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 1,
                column: "PriceList",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 2,
                column: "PriceList",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 3,
                column: "PriceList",
                value: "[5000]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 4,
                column: "PriceList",
                value: "[50000]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 5,
                column: "PriceList",
                value: "[50400]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 6,
                column: "PriceList",
                value: "[4500]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 7,
                column: "PriceList",
                value: "[95000]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 8,
                column: "PriceList",
                value: "[36800]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 9,
                column: "PriceList",
                value: "[89000]");
        }
    }
}
