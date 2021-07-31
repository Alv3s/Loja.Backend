using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja.Backend.DBObjects.Migrations
{
    public partial class AddedVATcolumntoProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "VAT",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VAT",
                table: "Products");
        }
    }
}
