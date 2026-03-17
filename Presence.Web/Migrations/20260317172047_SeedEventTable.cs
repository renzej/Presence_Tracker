using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presence.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedEventTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Name", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "March Prayer Meeting", 1 },
                    { 2, new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Church Service", 0 },
                    { 3, new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Band Practice", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
