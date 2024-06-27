using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SpecialRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "https://example.com/categories/fiction.jpg", "Fiction" },
                    { 2, "https://example.com/categories/non-fiction.jpg", "Non-Fiction" },
                    { 3, "https://example.com/categories/science-fiction.jpg", "Science Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerName", "Email", "OrderDate", "PhoneNumber", "Quantity", "SpecialRequest" },
                values: new object[,]
                {
                    { 1, "Alice Johnson", "alicejohnson@example.com", new DateTime(2024, 4, 14, 0, 29, 9, 142, DateTimeKind.Local).AddTicks(7289), "555-123-4567", 2, "Gift wrapping required." },
                    { 2, "Bob Smith", "bobsmith@example.com", new DateTime(2024, 4, 17, 0, 29, 9, 142, DateTimeKind.Local).AddTicks(7344), "555-987-6543", 1, "Express delivery needed." },
                    { 3, "Eve Brown", "evebrown@example.com", new DateTime(2024, 4, 21, 0, 29, 9, 142, DateTimeKind.Local).AddTicks(7347), "555-789-0123", 3, "Include a personal message." }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Harper Lee", 1, "https://example.com/books/to-kill-a-mockingbird.jpg", 10.99, "To Kill a Mockingbird" },
                    { 2, "F. Scott Fitzgerald", 1, "https://example.com/books/the-great-gatsby.jpg", 12.5, "The Great Gatsby" },
                    { 3, "Yuval Noah Harari", 2, "https://example.com/books/sapiens.jpg", 15.949999999999999, "Sapiens: A Brief History of Humankind" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
