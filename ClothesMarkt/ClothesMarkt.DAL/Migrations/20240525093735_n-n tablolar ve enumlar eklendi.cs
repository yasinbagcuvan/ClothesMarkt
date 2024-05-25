using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesMarkt.DAL.Migrations
{
    /// <inheritdoc />
    public partial class nntablolarveenumlareklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shirts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ProductSize = table.Column<int>(type: "int", nullable: false),
                    KolTipi = table.Column<int>(type: "int", nullable: false),
                    KolBoyu = table.Column<int>(type: "int", nullable: false),
                    CepTipi = table.Column<int>(type: "int", nullable: false),
                    ShirtBaski = table.Column<int>(type: "int", nullable: false),
                    ShirtDesen = table.Column<int>(type: "int", nullable: false),
                    ShirtDokumaTipi = table.Column<int>(type: "int", nullable: false),
                    ShirtKalip = table.Column<int>(type: "int", nullable: false),
                    ShirtKolTipi = table.Column<int>(type: "int", nullable: false),
                    ShirtKumasTipi = table.Column<int>(type: "int", nullable: false),
                    ShirtMateryal = table.Column<int>(type: "int", nullable: false),
                    ShirtYakaTipi = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shirts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shirts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tshirts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ProductSize = table.Column<int>(type: "int", nullable: false),
                    KolTipi = table.Column<int>(type: "int", nullable: false),
                    KolBoyu = table.Column<int>(type: "int", nullable: false),
                    CepTipi = table.Column<int>(type: "int", nullable: false),
                    YakaTipi = table.Column<int>(type: "int", nullable: false),
                    Kalip = table.Column<int>(type: "int", nullable: false),
                    Materyal = table.Column<int>(type: "int", nullable: false),
                    Baski = table.Column<int>(type: "int", nullable: false),
                    DokumaTipi = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tshirts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tshirts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShirtsRenklers",
                columns: table => new
                {
                    ShirtId = table.Column<int>(type: "int", nullable: false),
                    RenkId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShirtsRenklers", x => new { x.ShirtId, x.RenkId });
                    table.ForeignKey(
                        name: "FK_ShirtsRenklers_Colors_RenkId",
                        column: x => x.RenkId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShirtsRenklers_Shirts_ShirtId",
                        column: x => x.ShirtId,
                        principalTable: "Shirts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TshirtsRenklers",
                columns: table => new
                {
                    TshirtId = table.Column<int>(type: "int", nullable: false),
                    RenkId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TshirtsRenklers_Tshirts_TshirtId",
                        column: x => x.TshirtId,
                        principalTable: "Tshirts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2c8faab-5a72-475d-9dc3-182b64e29f02", "AQAAAAIAAYagAAAAECJ0RqN8tu0uabH8kBLUd0I/Iyfi8ODvcLfCr064xVg/ScfgWCY4AaPyVT4u0JylXw==", "dbf52d9a-d48c-4cc2-9a80-dcafc99dbfb6" });

            migrationBuilder.CreateIndex(
                name: "IX_Shirts_CategoryId",
                table: "Shirts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShirtsRenklers_RenkId",
                table: "ShirtsRenklers",
                column: "RenkId");

            migrationBuilder.CreateIndex(
                name: "IX_Tshirts_CategoryId",
                table: "Tshirts",
                column: "CategoryId");

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

            migrationBuilder.DropTable(
                name: "Shirts");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Tshirts");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Baski = table.Column<int>(type: "int", nullable: false),
                    CepTipi = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DokumaTipi = table.Column<int>(type: "int", nullable: false),
                    Kalip = table.Column<int>(type: "int", nullable: false),
                    KnownColor = table.Column<int>(type: "int", nullable: false),
                    KolBoyu = table.Column<int>(type: "int", nullable: false),
                    KolTipi = table.Column<int>(type: "int", nullable: false),
                    Materyal = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductSize = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YakaTipi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bdc03d3-515b-4d28-9781-b84e9e471abb", "AQAAAAIAAYagAAAAEMWhUaexB5IWphrEf/2gIb47SHP4hMl6tlwFTqW4BLhsNbLzkqYrvkJKMV2Y+9i+sA==", "c3f6c756-53ab-493b-9e74-0aad0988cdea" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }
    }
}
