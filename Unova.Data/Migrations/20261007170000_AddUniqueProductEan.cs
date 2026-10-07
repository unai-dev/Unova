using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations;

[DbContext(typeof(UnovaDbContext))]
[Migration("20261007170000_AddUniqueProductEan")]
public partial class AddUniqueProductEan : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateIndex(
            name: "IX_AspNetProducts_EAN",
            table: "AspNetProducts",
            column: "EAN",
            unique: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropIndex(
            name: "IX_AspNetProducts_EAN",
            table: "AspNetProducts");
    }
}
