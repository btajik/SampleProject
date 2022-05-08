using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleProject.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 1, true, "Grunge Skater Jeans", null, 68m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 2, true, "Polo Shirt", null, 35m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 3, true, "Skater Graphic T-Shirt", null, 33m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 4, true, "Slicker Jacket", null, 125m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 5, true, "Thermal Fleece Jacket", null, 60m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 6, true, "Unisex Thermal Vest", null, 95m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 7, true, "V-Neck Pullover", null, 65m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 8, true, "V-Neck Sweater", null, 65m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 9, true, "V-Neck T-Shirt", null, 17m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 10, true, "Bamboo Thermal Ski Coat", null, 99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 11, false, "Cross-Back Training Tank", null, 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 12, true, "Grunge Skater Jeans", null, 68m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 13, true, "Slicker Jacket", null, 125m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 14, true, "Stretchy Dance Pants", null, 55m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 15, true, "Ultra-Soft Tank Top", null, 22m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 16, true, "Unisex Thermal Vest", null, 95m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 17, true, "V-Next T-Shirt", null, 17m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 18, true, "Blueberry Mineral Water", null, 2.8m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 19, true, "Lemon-Lime Mineral Water", null, 2.8m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 20, true, "Orange Mineral Water", null, 2.8m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 21, true, "Peach Mineral Water", null, 2.8m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 22, true, "Raspberry Mineral Water", null, 2.8m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 23, true, "Strawberry Mineral Water", null, 2.8m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 24, true, "In the Kitchen with H+ Sport", null, 24.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 25, true, "Calcium 400 IU (150 tablets)", null, 9.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 26, true, "Flaxseed Oil 100 mg (90 capsules)", null, 12.49m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 27, true, "Iron 65 mg (150 caplets)", null, 13.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 28, true, "Magnesium 250 mg (100 tablets)", null, 12.49m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 29, true, "Multi-Vitamin (90 capsules)", null, 9.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 30, true, "Vitamin A 10,000 IU (125 caplets)", null, 11.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 31, true, "Vitamin B-Complex (100 caplets)", null, 12.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 32, true, "Vitamin C 1000 mg (100 tablets)", null, 9.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "IsAvailable", "Name", "OrderId", "Price" },
                values: new object[] { 33, true, "Vitamin D3 1000 IU (100 tablets)", null, 12.49m });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email" },
                values: new object[] { 1, "Tajik.WorkEmail@example.com" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email" },
                values: new object[] { 2, "hggjh@example.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
