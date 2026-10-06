using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DeleteCenterEnterpriseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetLocations_AspNetCenters_CenterID",
                table: "AspNetLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetCenters_CenterID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetEnterprises_EnterpriseID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AspNetCenters");

            migrationBuilder.DropTable(
                name: "AspNetEnterprises");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CenterID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EnterpriseID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetLocations_CenterID",
                table: "AspNetLocations");

            migrationBuilder.DropColumn(
                name: "CenterID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EnterpriseID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CenterID",
                table: "AspNetLocations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CenterID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnterpriseID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CenterID",
                table: "AspNetLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AspNetEnterprises",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetEnterprises", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AspNetEnterprises_AspNetAddresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "AspNetAddresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetCenters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnterpriseID = table.Column<int>(type: "int", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetCenters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AspNetCenters_AspNetEnterprises_EnterpriseID",
                        column: x => x.EnterpriseID,
                        principalTable: "AspNetEnterprises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CenterID",
                table: "AspNetUsers",
                column: "CenterID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EnterpriseID",
                table: "AspNetUsers",
                column: "EnterpriseID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetLocations_CenterID",
                table: "AspNetLocations",
                column: "CenterID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetCenters_EnterpriseID",
                table: "AspNetCenters",
                column: "EnterpriseID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetEnterprises_AddressID",
                table: "AspNetEnterprises",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetLocations_AspNetCenters_CenterID",
                table: "AspNetLocations",
                column: "CenterID",
                principalTable: "AspNetCenters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetCenters_CenterID",
                table: "AspNetUsers",
                column: "CenterID",
                principalTable: "AspNetCenters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetEnterprises_EnterpriseID",
                table: "AspNetUsers",
                column: "EnterpriseID",
                principalTable: "AspNetEnterprises",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
