using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rohan_Phadtare_DotnetAssignment6_CodeFirstAPI.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peripherals",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 10, 5, 12, 14, 26, 420, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Peripherals",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 10, 10, 12, 14, 26, 420, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Peripherals",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2025, 10, 13, 12, 14, 26, 420, DateTimeKind.Utc).AddTicks(4558));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peripherals",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 10, 5, 12, 12, 41, 85, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Peripherals",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 10, 10, 12, 12, 41, 85, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Peripherals",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2025, 10, 13, 12, 12, 41, 85, DateTimeKind.Utc).AddTicks(3951));
        }
    }
}
