using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesMarkt.DAL.Migrations
{
    /// <inheritdoc />
    public partial class rowNumAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RowNum",
                table: "TshirtsRenklers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowNum",
                table: "Tshirts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowNum",
                table: "ShirtsRenklers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowNum",
                table: "Shirts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowNum",
                table: "Colors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowNum",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62785237-68ed-497d-9028-9c3d9bc67c59", "AQAAAAIAAYagAAAAEABrJhRYMyMLmP3HQE6eA1oRjWDnLrX6fFD7k7E+YNtO0e5Gl8IFejk1q0bDKU4fNg==", "5e924fbf-bfbc-4b0e-a66b-c6d970d61e30" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowNum",
                table: "TshirtsRenklers");

            migrationBuilder.DropColumn(
                name: "RowNum",
                table: "Tshirts");

            migrationBuilder.DropColumn(
                name: "RowNum",
                table: "ShirtsRenklers");

            migrationBuilder.DropColumn(
                name: "RowNum",
                table: "Shirts");

            migrationBuilder.DropColumn(
                name: "RowNum",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "RowNum",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2c8faab-5a72-475d-9dc3-182b64e29f02", "AQAAAAIAAYagAAAAECJ0RqN8tu0uabH8kBLUd0I/Iyfi8ODvcLfCr064xVg/ScfgWCY4AaPyVT4u0JylXw==", "dbf52d9a-d48c-4cc2-9a80-dcafc99dbfb6" });
        }
    }
}
