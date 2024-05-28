using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesMarkt.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ShirtsRenklerscolumnchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "ShirtsRenklers");

            migrationBuilder.DropColumn(
                name: "RowNum",
                table: "ShirtsRenklers");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ShirtsRenklers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1a58037-3656-467b-a273-07bd4f453679", "AQAAAAIAAYagAAAAEKv2prZbz71X2VjKyjHTj68YNkFp8vke7QgRw01Ajh42Af8XqpykOdsW+Tdy6c1dsw==", "f8e871df-a161-4824-a87f-ed122747aa1c" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 17, 13, 474, DateTimeKind.Local).AddTicks(9329));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ShirtsRenklers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RowNum",
                table: "ShirtsRenklers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "ShirtsRenklers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a232034-7a38-46ad-8eef-df09f54a0303", "AQAAAAIAAYagAAAAEFmOhSJvu0o4uAnOCBkEUdODc/U38w0uINglSfVzfzKQ1QEYlj2gLeLbQAlWTp3Ckg==", "05ce0739-e5f0-442a-8cac-ca85d2527ef1" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 5, 26, 17, 28, 3, 56, DateTimeKind.Local).AddTicks(9801));
        }
    }
}
