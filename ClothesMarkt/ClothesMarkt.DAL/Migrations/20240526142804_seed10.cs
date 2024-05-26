using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothesMarkt.DAL.Migrations
{
    /// <inheritdoc />
    public partial class seed10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a232034-7a38-46ad-8eef-df09f54a0303", "AQAAAAIAAYagAAAAEFmOhSJvu0o4uAnOCBkEUdODc/U38w0uINglSfVzfzKQ1QEYlj2gLeLbQAlWTp3Ckg==", "05ce0739-e5f0-442a-8cac-ca85d2527ef1" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Created", "Name", "RowNum", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9763), "Altın", null, null },
                    { 2, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9765), "Bej", null, null },
                    { 3, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9768), "Beyaz", null, null },
                    { 4, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9770), "Bordo", null, null },
                    { 5, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9772), "Ekru", null, null },
                    { 6, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9774), "Gri", null, null },
                    { 7, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9776), "Gümüş", null, null },
                    { 8, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9777), "Haki", null, null },
                    { 9, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9779), "Kahverengi", null, null },
                    { 10, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9781), "Kırmızı", null, null },
                    { 11, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9783), "Lacivert", null, null },
                    { 12, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9785), "Mavi", null, null },
                    { 13, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9787), "Metalik", null, null },
                    { 14, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9788), "Mor", null, null },
                    { 15, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9790), "Pembe", null, null },
                    { 16, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9792), "Sarı", null, null },
                    { 17, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9794), "Siyah", null, null },
                    { 18, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9796), "Turkuaz", null, null },
                    { 19, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9797), "Turuncu", null, null },
                    { 20, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9799), "Yeşil", null, null },
                    { 21, new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9801), "Çok Renkli", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e202d3a1-34e6-4abf-84e2-d65591bda9bb", "AQAAAAIAAYagAAAAEDKHT0rRY9VLHf4fsqDSwj9+7ws0H1XqM5ebb6dSFkU9eOLQUQqn7XklS301c9L/Bw==", "6c35fbd1-39af-4dd2-9c98-25904faf0ef5" });
        }
    }
}
