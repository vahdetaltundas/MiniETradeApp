using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniETradeApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Products",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatDate",
                table: "Products",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Orders",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatDate",
                table: "Orders",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Customers",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatDate",
                table: "Customers",
                newName: "CreatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Products",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Products",
                newName: "CreatDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Orders",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Orders",
                newName: "CreatDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Customers",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Customers",
                newName: "CreatDate");
        }
    }
}
