using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LocationHasData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "asp_Locations",
                columns: new[] { "ID", "Aisle", "CenterID", "Column", "CreatedAt", "IsActive", "Shelf", "UpdatedAt" },
                values: new object[] { 1, "N/A", 0, "N/A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "N/A", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asp_Locations",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
