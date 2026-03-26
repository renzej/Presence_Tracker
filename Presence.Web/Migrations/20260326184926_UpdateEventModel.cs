using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presence.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEventModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Events",
                newName: "StartDateTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "Events",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime", "Status" },
                values: new object[] { new DateTime(2025, 3, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDateTime", "Name", "StartDateTime", "Status" },
                values: new object[] { new DateTime(2025, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "Brother CJ Sermon", new DateTime(2025, 3, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDateTime", "Name", "StartDateTime", "Status", "Type" },
                values: new object[] { new DateTime(2025, 3, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Brother Jan Sermon", new DateTime(2025, 3, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 0 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EndDateTime", "Name", "StartDateTime", "Status", "Type" },
                values: new object[] { 4, null, "Band Practice", new DateTime(2025, 3, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "StartDateTime",
                table: "Events",
                newName: "Date");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Name" },
                values: new object[] { new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Church Service" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Name", "Type" },
                values: new object[] { new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Band Practice", 3 });
        }
    }
}
