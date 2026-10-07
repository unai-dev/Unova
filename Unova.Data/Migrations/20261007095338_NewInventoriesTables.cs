using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewInventoriesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetInventories");

            migrationBuilder.CreateTable(
                name: "AspNetBookInventories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailableCopies = table.Column<int>(type: "int", nullable: false),
                    ReservedCopies = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<int>(type: "int", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetBookInventories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AspNetBookInventories_AspNetBooks_BookID",
                        column: x => x.BookID,
                        principalTable: "AspNetBooks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetBookInventories_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetProducts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    EAN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Price = table.Column<double>(type: "float(15)", precision: 15, scale: 2, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AspNetProducts_AspNetCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "AspNetCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetProductInventories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: false),
                    Inactive = table.Column<int>(type: "int", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetProductInventories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AspNetProductInventories_AspNetProducts_ProductID",
                        column: x => x.ProductID,
                        principalTable: "AspNetProducts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetProductInventories_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBookInventories_BookID",
                table: "AspNetBookInventories",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBookInventories_UserID",
                table: "AspNetBookInventories",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetProductInventories_ProductID",
                table: "AspNetProductInventories",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetProductInventories_UserID",
                table: "AspNetProductInventories",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetProducts_CategoryID",
                table: "AspNetProducts",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetBookInventories");

            migrationBuilder.DropTable(
                name: "AspNetProductInventories");

            migrationBuilder.DropTable(
                name: "AspNetProducts");

            migrationBuilder.CreateTable(
                name: "AspNetInventories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AvailableCopies = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ReservedCopies = table.Column<int>(type: "int", nullable: false),
                    TotalCopies = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetInventories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AspNetInventories_AspNetBooks_BookID",
                        column: x => x.BookID,
                        principalTable: "AspNetBooks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetInventories_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetInventories_BookID",
                table: "AspNetInventories",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetInventories_UserID",
                table: "AspNetInventories",
                column: "UserID");
        }
    }
}
