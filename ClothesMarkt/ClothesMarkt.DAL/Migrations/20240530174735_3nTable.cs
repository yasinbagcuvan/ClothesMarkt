using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesMarkt.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _3nTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RenkShirt");

            migrationBuilder.DropTable(
                name: "RenkTshirt");

            migrationBuilder.CreateTable(
                name: "ShirtsRenklers",
                columns: table => new
                {
                    ShirtsId = table.Column<int>(type: "int", nullable: false),
                    RenklerId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShirtsRenklers", x => new { x.ShirtsId, x.RenklerId });
                    table.ForeignKey(
                        name: "FK_ShirtsRenklers_Colors_RenklerId",
                        column: x => x.RenklerId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShirtsRenklers_Shirts_ShirtsId",
                        column: x => x.ShirtsId,
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
                    Id = table.Column<int>(type: "int", nullable: false),
                    RowNum = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                values: new object[] { "67351c8f-5464-4477-be02-f7fb9f68ddca", "AQAAAAIAAYagAAAAEI9aKPVq+Uv7twZpS0mVSTfrt2J8wMGvRgqDwRguk346i0a2khH5WIPzIbD1+rEbzQ==", "21d12131-2820-4916-9eb0-de0951d9952e" });

            migrationBuilder.CreateIndex(
                name: "IX_ShirtsRenklers_RenklerId",
                table: "ShirtsRenklers",
                column: "RenklerId");

            migrationBuilder.CreateIndex(
                name: "IX_TshirtsRenklers_RenkId",
                table: "TshirtsRenklers",
                column: "RenkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShirtsRenklers");

            migrationBuilder.DropTable(
                name: "TshirtsRenklers");

            migrationBuilder.CreateTable(
                name: "RenkShirt",
                columns: table => new
                {
                    ShirtsId = table.Column<int>(type: "int", nullable: false),
                    RenklerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RenkShirt", x => new { x.ShirtsId, x.RenklerId });
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
                values: new object[] { "07391c01-f7a3-4155-90c1-1d473921991a", "AQAAAAIAAYagAAAAENxqyHGKuS9xiT1j8RHF0YzIsVlGqrrZgvBfcT3PHUljiuYXxbm79aaid07WSJoqtQ==", "9fd80122-ccf0-4de1-963c-2f049c1bcec7" });

            migrationBuilder.CreateIndex(
                name: "IX_RenkShirt_RenklerId",
                table: "RenkShirt",
                column: "RenklerId");

            migrationBuilder.CreateIndex(
                name: "IX_RenkTshirt_TshirtsId",
                table: "RenkTshirt",
                column: "TshirtsId");
        }
    }
}
