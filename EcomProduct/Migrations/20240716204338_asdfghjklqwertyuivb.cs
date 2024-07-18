using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomProduct.Migrations
{
    /// <inheritdoc />
    public partial class asdfghjklqwertyuivb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgURL",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ImgURL",
                table: "ProductImages");
        }
    }
}
