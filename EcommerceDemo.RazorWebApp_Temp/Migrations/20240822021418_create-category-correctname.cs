using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceDemo.RazorWebApp_Temp.Migrations
{
    /// <inheritdoc />
    public partial class createcategorycorrectname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Category_temp",
                table: "Category_temp");

            migrationBuilder.RenameTable(
                name: "Category_temp",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category_temp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category_temp",
                table: "Category_temp",
                column: "Id");
        }
    }
}
