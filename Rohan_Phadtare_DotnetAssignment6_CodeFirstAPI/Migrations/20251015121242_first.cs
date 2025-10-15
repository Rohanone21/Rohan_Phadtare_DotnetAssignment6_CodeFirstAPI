using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rohan_Phadtare_DotnetAssignment6_CodeFirstAPI.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peripherals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peripherals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Peripherals",
                columns: new[] { "Id", "AddedDate", "Category", "Name", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 5, 12, 12, 41, 85, DateTimeKind.Utc).AddTicks(3243), "Keyboard", "Mechanical Keyboard RGB", 89.99m, 15 },
                    { 2, new DateTime(2025, 10, 10, 12, 12, 41, 85, DateTimeKind.Utc).AddTicks(3937), "Mouse", "Wireless Gaming Mouse", 49.99m, 25 },
                    { 3, new DateTime(2025, 10, 13, 12, 12, 41, 85, DateTimeKind.Utc).AddTicks(3951), "Monitor", "27-inch 4K Monitor", 299.99m, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peripherals");
        }
    }
}
