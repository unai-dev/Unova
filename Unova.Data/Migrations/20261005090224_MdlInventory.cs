using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MdlInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asp_Inventories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCopies = table.Column<int>(type: "int", nullable: false),
                    CopiesWithLocation = table.Column<int>(type: "int", nullable: false),
                    CopiesWithoutLocation = table.Column<int>(type: "int", nullable: false),
                    ReservedCopies = table.Column<int>(type: "int", nullable: false),
                    AvailableCopies = table.Column<int>(type: "int", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asp_Inventories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_asp_Inventories_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_asp_Inventories_asp_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "asp_Books",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_asp_Inventories_BookID",
                table: "asp_Inventories",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_asp_Inventories_UserID",
                table: "asp_Inventories",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asp_Inventories");
        }
    }
}
