using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IndexUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AspNetLanguages_Iso639Code",
                table: "AspNetLanguages",
                column: "Iso639Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetCopies_Code",
                table: "AspNetCopies",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetCategories_Name",
                table: "AspNetCategories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBooks_ISBN",
                table: "AspNetBooks",
                column: "ISBN",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetLanguages_Iso639Code",
                table: "AspNetLanguages");

            migrationBuilder.DropIndex(
                name: "IX_AspNetCopies_Code",
                table: "AspNetCopies");

            migrationBuilder.DropIndex(
                name: "IX_AspNetCategories_Name",
                table: "AspNetCategories");

            migrationBuilder.DropIndex(
                name: "IX_AspNetBooks_ISBN",
                table: "AspNetBooks");
        }
    }
}
