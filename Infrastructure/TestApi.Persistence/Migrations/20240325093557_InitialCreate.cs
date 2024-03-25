using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApi.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priorty = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priorty = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskItems_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 25, 12, 35, 56, 750, DateTimeKind.Local).AddTicks(7187), false, "Home, Outdoors & Movies" },
                    { 2, new DateTime(2024, 3, 25, 12, 35, 56, 750, DateTimeKind.Local).AddTicks(7202), false, "Computers, Grocery & Home" },
                    { 3, new DateTime(2024, 3, 25, 12, 35, 56, 750, DateTimeKind.Local).AddTicks(7210), true, "Computers & Movies" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 25, 12, 35, 56, 750, DateTimeKind.Local).AddTicks(7719), false, "Electronic", 0, 1 },
                    { 2, new DateTime(2024, 3, 25, 12, 35, 56, 750, DateTimeKind.Local).AddTicks(7721), false, "Fashion", 0, 2 },
                    { 3, new DateTime(2024, 3, 25, 12, 35, 56, 750, DateTimeKind.Local).AddTicks(7722), false, "Computer", 1, 1 },
                    { 4, new DateTime(2024, 3, 25, 12, 35, 56, 750, DateTimeKind.Local).AddTicks(7723), false, "Women", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 25, 12, 35, 56, 757, DateTimeKind.Local).AddTicks(6179), false, "Migros", 1 },
                    { 2, new DateTime(2024, 3, 25, 12, 35, 56, 757, DateTimeKind.Local).AddTicks(6181), false, "Anpa Gross", 2 },
                    { 3, new DateTime(2024, 3, 25, 12, 35, 56, 757, DateTimeKind.Local).AddTicks(6183), true, "Happy Center", 3 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 25, 12, 35, 56, 753, DateTimeKind.Local).AddTicks(8869), "Repellendus eligendi vero recusandae et.", false, "Qui." },
                    { 2, 3, new DateTime(2024, 3, 25, 12, 35, 56, 753, DateTimeKind.Local).AddTicks(8911), "Et quod consectetur qui soluta.", true, "Tempore pariatur." },
                    { 3, 4, new DateTime(2024, 3, 25, 12, 35, 56, 753, DateTimeKind.Local).AddTicks(8943), "Voluptatem necessitatibus alias non tempora.", false, "İtaque." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 25, 12, 35, 56, 757, DateTimeKind.Local).AddTicks(5425), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 9.268903669606020m, false, 695.68m, "Unbranded Steel Bacon" },
                    { 2, 3, new DateTime(2024, 3, 25, 12, 35, 56, 757, DateTimeKind.Local).AddTicks(5456), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1.819564604791140m, false, 69.99m, "Fantastic Rubber Hat" }
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreatedDate", "Description", "IsCompleted", "IsDeleted", "Quantity", "StoreId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 25, 12, 35, 56, 760, DateTimeKind.Local).AddTicks(2307), "Sapiente corporis et eius ipsa.", false, false, "5 pcs", 1 },
                    { 2, new DateTime(2024, 3, 25, 12, 35, 56, 760, DateTimeKind.Local).AddTicks(2418), "Magnam culpa quia illum consequuntur.", false, false, "500 gr.", 2 },
                    { 3, new DateTime(2024, 3, 25, 12, 35, 56, 760, DateTimeKind.Local).AddTicks(2440), "Veniam et molestiae perspiciatis quidem.", false, true, "1 kg.", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_StoreId",
                table: "TaskItems",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "TaskItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
