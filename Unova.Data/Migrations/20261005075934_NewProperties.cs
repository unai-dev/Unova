using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asp_Bookings_asp_Books_BookID",
                table: "asp_Bookings");

            migrationBuilder.RenameColumn(
                name: "LimitOfBooks",
                table: "asp_Locations",
                newName: "Limit");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "asp_Enterprises",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "asp_Enterprises",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "BookID",
                table: "asp_Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CopyID",
                table: "asp_Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_asp_Bookings_CopyID",
                table: "asp_Bookings",
                column: "CopyID");

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Bookings_asp_Books_BookID",
                table: "asp_Bookings",
                column: "BookID",
                principalTable: "asp_Books",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Bookings_asp_Copies_CopyID",
                table: "asp_Bookings",
                column: "CopyID",
                principalTable: "asp_Copies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asp_Bookings_asp_Books_BookID",
                table: "asp_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Bookings_asp_Copies_CopyID",
                table: "asp_Bookings");

            migrationBuilder.DropIndex(
                name: "IX_asp_Bookings_CopyID",
                table: "asp_Bookings");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "asp_Enterprises");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "asp_Enterprises");

            migrationBuilder.DropColumn(
                name: "CopyID",
                table: "asp_Bookings");

            migrationBuilder.RenameColumn(
                name: "Limit",
                table: "asp_Locations",
                newName: "LimitOfBooks");

            migrationBuilder.AlterColumn<int>(
                name: "BookID",
                table: "asp_Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Bookings_asp_Books_BookID",
                table: "asp_Bookings",
                column: "BookID",
                principalTable: "asp_Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
