using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CodeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "AspNetLocations",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "AspNetAuthors",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "AspNetAddresses",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetAuthors",
                keyColumn: "ID",
                keyValue: 1,
                column: "Code",
                value: "111");

            migrationBuilder.UpdateData(
                table: "AspNetAuthors",
                keyColumn: "ID",
                keyValue: 2,
                column: "Code",
                value: "222");

            migrationBuilder.UpdateData(
                table: "AspNetAuthors",
                keyColumn: "ID",
                keyValue: 3,
                column: "Code",
                value: "333");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetLocations_Code",
                table: "AspNetLocations",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetAuthors_Code",
                table: "AspNetAuthors",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetAddresses_Code",
                table: "AspNetAddresses",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetLocations_Code",
                table: "AspNetLocations");

            migrationBuilder.DropIndex(
                name: "IX_AspNetAuthors_Code",
                table: "AspNetAuthors");

            migrationBuilder.DropIndex(
                name: "IX_AspNetAddresses_Code",
                table: "AspNetAddresses");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "AspNetLocations");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "AspNetAuthors");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "AspNetAddresses");
        }
    }
}
