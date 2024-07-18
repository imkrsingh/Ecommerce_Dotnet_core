using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomProduct.Migrations
{
    /// <inheritdoc />
    public partial class asdfghjklwertyhjkvbn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgURL",
                table: "ProductImages",
                newName: "URL");

            migrationBuilder.RenameColumn(
                name: "ImgName",
                table: "ProductImages",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "URL",
                table: "ProductImages",
                newName: "ImgURL");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductImages",
                newName: "ImgName");
        }
    }
}
