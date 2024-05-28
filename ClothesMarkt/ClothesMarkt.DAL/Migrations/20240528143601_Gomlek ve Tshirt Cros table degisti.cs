using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesMarkt.DAL.Migrations
{
    /// <inheritdoc />
    public partial class GomlekveTshirtCrostabledegisti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShirtsRenklers");

            migrationBuilder.DropTable(
                name: "TshirtsRenklers");

            migrationBuilder.CreateTable(
                name: "RenkShirt",
                columns: table => new
                {
                    RenklerId = table.Column<int>(type: "int", nullable: false),
                    ShirtsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RenkShirt", x => new { x.RenklerId, x.ShirtsId });
                    table.ForeignKey(
                        name: "FK_RenkShirt_Colors_RenklerId",
                        column: x => x.RenklerId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RenkShirt_Shirts_ShirtsId",
                        column: x => x.ShirtsId,
                        principalTable: "Shirts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RenkTshirt",
                columns: table => new
                {
                    RenklerId = table.Column<int>(type: "int", nullable: false),
                    TshirtsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RenkTshirt", x => new { x.RenklerId, x.TshirtsId });
                    table.ForeignKey(
                        name: "FK_RenkTshirt_Colors_RenklerId",
                        column: x => x.RenklerId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RenkTshirt_Tshirts_TshirtsId",
                        column: x => x.TshirtsId,
                        principalTable: "Tshirts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee1c0fb8-4fbf-4550-8c3c-1a02dad361ed", "AQAAAAIAAYagAAAAEGdcRpN2hKXjVWINkaTDUunzx3/40juu8EeZZ1snDZ8sOWbODFhP+Dspau8fRV2m2g==", "40409eef-95ad-4213-86ed-56efffb1b6fc" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 5, 28, 17, 35, 59, 859, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.CreateIndex(
                name: "IX_RenkShirt_ShirtsId",
                table: "RenkShirt",
                column: "ShirtsId");

            migrationBuilder.CreateIndex(
                name: "IX_RenkTshirt_TshirtsId",
                table: "RenkTshirt",
                column: "TshirtsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RenkShirt");

            migrationBuilder.DropTable(
                name: "RenkTshirt");

            migrationBuilder.CreateTable(
                name: "ShirtsRenklers",
                columns: table => new
                {
                    ShirtId = table.Column<int>(type: "int", nullable: false),
                    RenkId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShirtsRenklers", x => new { x.ShirtId, x.RenkId });
                    table.ForeignKey(
                        name: "FK_ShirtsRenklers_Colors_RenkId",
                        column: x => x.RenkId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShirtsRenklers_Shirts_ShirtId",
                        column: x => x.ShirtId,
                        principalTable: "Shirts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TshirtsRenklers",
                columns: table => new
                {
                    TshirtId = table.Column<int>(type: "int", nullable: false),
                    RenkId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    RowNum = table.Column<int>(type: "int", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TshirtsRenklers", x => new { x.TshirtId, x.RenkId });
                    table.ForeignKey(
                        name: "FK_TshirtsRenklers_Colors_RenkId",
                        column: x => x.RenkId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TshirtsRenklers_Tshirts_TshirtId",
                        column: x => x.TshirtId,
                        principalTable: "Tshirts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ShirtsRenklers_RenkId",
                table: "ShirtsRenklers",
                column: "RenkId");

            migrationBuilder.CreateIndex(
                name: "IX_TshirtsRenklers_RenkId",
                table: "TshirtsRenklers",
                column: "RenkId");
        }
    }
}
