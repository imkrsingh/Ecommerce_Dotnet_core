using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomProduct.Migrations
{
    /// <inheritdoc />
    public partial class asdfghjklqwertyui : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "ImgURL",
                table: "ProductImages",
                newName: "FileName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "ProductImages",
                newName: "ImgURL");

            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
