using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DistrictProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "asp_Addresses",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "asp_Addresses");
        }
    }
}
