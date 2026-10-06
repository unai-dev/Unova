using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unova.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameDBTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asp_Bookings_AspNetUsers_UserID",
                table: "asp_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Bookings_asp_Copies_CopyID",
                table: "asp_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Books_asp_Authors_AuthorID",
                table: "asp_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Books_asp_Categories_CategoryID",
                table: "asp_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Centers_asp_Enterprises_EnterpriseID",
                table: "asp_Centers");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Copies_asp_Books_BookID",
                table: "asp_Copies");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Copies_asp_Locations_LocationID",
                table: "asp_Copies");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Enterprises_asp_Addresses_AddressID",
                table: "asp_Enterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Inventories_AspNetUsers_UserID",
                table: "asp_Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Inventories_asp_Books_BookID",
                table: "asp_Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_asp_Locations_asp_Centers_CenterID",
                table: "asp_Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_asp_Centers_CenterID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_asp_Enterprises_EnterpriseID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_asp_Languages_LanguageID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Locations",
                table: "asp_Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Languages",
                table: "asp_Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Inventories",
                table: "asp_Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Enterprises",
                table: "asp_Enterprises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Copies",
                table: "asp_Copies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Centers",
                table: "asp_Centers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Categories",
                table: "asp_Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Books",
                table: "asp_Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Bookings",
                table: "asp_Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Authors",
                table: "asp_Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asp_Addresses",
                table: "asp_Addresses");

            migrationBuilder.RenameTable(
                name: "asp_Locations",
                newName: "AspNetLocations");

            migrationBuilder.RenameTable(
                name: "asp_Languages",
                newName: "AspNetLanguages");

            migrationBuilder.RenameTable(
                name: "asp_Inventories",
                newName: "AspNetInventories");

            migrationBuilder.RenameTable(
                name: "asp_Enterprises",
                newName: "AspNetEnterprises");

            migrationBuilder.RenameTable(
                name: "asp_Copies",
                newName: "AspNetCopies");

            migrationBuilder.RenameTable(
                name: "asp_Centers",
                newName: "AspNetCenters");

            migrationBuilder.RenameTable(
                name: "asp_Categories",
                newName: "AspNetCategories");

            migrationBuilder.RenameTable(
                name: "asp_Books",
                newName: "AspNetBooks");

            migrationBuilder.RenameTable(
                name: "asp_Bookings",
                newName: "AspNetBookings");

            migrationBuilder.RenameTable(
                name: "asp_Authors",
                newName: "AspNetAuthors");

            migrationBuilder.RenameTable(
                name: "asp_Addresses",
                newName: "AspNetAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Locations_CenterID",
                table: "AspNetLocations",
                newName: "IX_AspNetLocations_CenterID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Inventories_UserID",
                table: "AspNetInventories",
                newName: "IX_AspNetInventories_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Inventories_BookID",
                table: "AspNetInventories",
                newName: "IX_AspNetInventories_BookID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Enterprises_AddressID",
                table: "AspNetEnterprises",
                newName: "IX_AspNetEnterprises_AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Copies_LocationID",
                table: "AspNetCopies",
                newName: "IX_AspNetCopies_LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Copies_BookID",
                table: "AspNetCopies",
                newName: "IX_AspNetCopies_BookID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Centers_EnterpriseID",
                table: "AspNetCenters",
                newName: "IX_AspNetCenters_EnterpriseID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Books_CategoryID",
                table: "AspNetBooks",
                newName: "IX_AspNetBooks_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Books_AuthorID",
                table: "AspNetBooks",
                newName: "IX_AspNetBooks_AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Bookings_UserID",
                table: "AspNetBookings",
                newName: "IX_AspNetBookings_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_asp_Bookings_CopyID",
                table: "AspNetBookings",
                newName: "IX_AspNetBookings_CopyID");

            migrationBuilder.AlterColumn<string>(
                name: "CIF",
                table: "AspNetUsers",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetLocations",
                table: "AspNetLocations",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetLanguages",
                table: "AspNetLanguages",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetInventories",
                table: "AspNetInventories",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetEnterprises",
                table: "AspNetEnterprises",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetCopies",
                table: "AspNetCopies",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetCenters",
                table: "AspNetCenters",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetCategories",
                table: "AspNetCategories",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetBooks",
                table: "AspNetBooks",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetBookings",
                table: "AspNetBookings",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetAuthors",
                table: "AspNetAuthors",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetAddresses",
                table: "AspNetAddresses",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetBookings_AspNetCopies_CopyID",
                table: "AspNetBookings",
                column: "CopyID",
                principalTable: "AspNetCopies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetBookings_AspNetUsers_UserID",
                table: "AspNetBookings",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetBooks_AspNetAuthors_AuthorID",
                table: "AspNetBooks",
                column: "AuthorID",
                principalTable: "AspNetAuthors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetBooks_AspNetCategories_CategoryID",
                table: "AspNetBooks",
                column: "CategoryID",
                principalTable: "AspNetCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetCenters_AspNetEnterprises_EnterpriseID",
                table: "AspNetCenters",
                column: "EnterpriseID",
                principalTable: "AspNetEnterprises",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetCopies_AspNetBooks_BookID",
                table: "AspNetCopies",
                column: "BookID",
                principalTable: "AspNetBooks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetCopies_AspNetLocations_LocationID",
                table: "AspNetCopies",
                column: "LocationID",
                principalTable: "AspNetLocations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetEnterprises_AspNetAddresses_AddressID",
                table: "AspNetEnterprises",
                column: "AddressID",
                principalTable: "AspNetAddresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetInventories_AspNetBooks_BookID",
                table: "AspNetInventories",
                column: "BookID",
                principalTable: "AspNetBooks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetInventories_AspNetUsers_UserID",
                table: "AspNetInventories",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetLanguages_LanguageID",
                table: "AspNetUsers",
                column: "LanguageID",
                principalTable: "AspNetLanguages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetBookings_AspNetCopies_CopyID",
                table: "AspNetBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetBookings_AspNetUsers_UserID",
                table: "AspNetBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetBooks_AspNetAuthors_AuthorID",
                table: "AspNetBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetBooks_AspNetCategories_CategoryID",
                table: "AspNetBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetCenters_AspNetEnterprises_EnterpriseID",
                table: "AspNetCenters");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetCopies_AspNetBooks_BookID",
                table: "AspNetCopies");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetCopies_AspNetLocations_LocationID",
                table: "AspNetCopies");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetEnterprises_AspNetAddresses_AddressID",
                table: "AspNetEnterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetInventories_AspNetBooks_BookID",
                table: "AspNetInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetInventories_AspNetUsers_UserID",
                table: "AspNetInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetLocations_AspNetCenters_CenterID",
                table: "AspNetLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetCenters_CenterID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetEnterprises_EnterpriseID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetLanguages_LanguageID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetLocations",
                table: "AspNetLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetLanguages",
                table: "AspNetLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetInventories",
                table: "AspNetInventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetEnterprises",
                table: "AspNetEnterprises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetCopies",
                table: "AspNetCopies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetCenters",
                table: "AspNetCenters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetCategories",
                table: "AspNetCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetBooks",
                table: "AspNetBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetBookings",
                table: "AspNetBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetAuthors",
                table: "AspNetAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetAddresses",
                table: "AspNetAddresses");

            migrationBuilder.RenameTable(
                name: "AspNetLocations",
                newName: "asp_Locations");

            migrationBuilder.RenameTable(
                name: "AspNetLanguages",
                newName: "asp_Languages");

            migrationBuilder.RenameTable(
                name: "AspNetInventories",
                newName: "asp_Inventories");

            migrationBuilder.RenameTable(
                name: "AspNetEnterprises",
                newName: "asp_Enterprises");

            migrationBuilder.RenameTable(
                name: "AspNetCopies",
                newName: "asp_Copies");

            migrationBuilder.RenameTable(
                name: "AspNetCenters",
                newName: "asp_Centers");

            migrationBuilder.RenameTable(
                name: "AspNetCategories",
                newName: "asp_Categories");

            migrationBuilder.RenameTable(
                name: "AspNetBooks",
                newName: "asp_Books");

            migrationBuilder.RenameTable(
                name: "AspNetBookings",
                newName: "asp_Bookings");

            migrationBuilder.RenameTable(
                name: "AspNetAuthors",
                newName: "asp_Authors");

            migrationBuilder.RenameTable(
                name: "AspNetAddresses",
                newName: "asp_Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetLocations_CenterID",
                table: "asp_Locations",
                newName: "IX_asp_Locations_CenterID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetInventories_UserID",
                table: "asp_Inventories",
                newName: "IX_asp_Inventories_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetInventories_BookID",
                table: "asp_Inventories",
                newName: "IX_asp_Inventories_BookID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetEnterprises_AddressID",
                table: "asp_Enterprises",
                newName: "IX_asp_Enterprises_AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetCopies_LocationID",
                table: "asp_Copies",
                newName: "IX_asp_Copies_LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetCopies_BookID",
                table: "asp_Copies",
                newName: "IX_asp_Copies_BookID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetCenters_EnterpriseID",
                table: "asp_Centers",
                newName: "IX_asp_Centers_EnterpriseID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetBooks_CategoryID",
                table: "asp_Books",
                newName: "IX_asp_Books_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetBooks_AuthorID",
                table: "asp_Books",
                newName: "IX_asp_Books_AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetBookings_UserID",
                table: "asp_Bookings",
                newName: "IX_asp_Bookings_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetBookings_CopyID",
                table: "asp_Bookings",
                newName: "IX_asp_Bookings_CopyID");

            migrationBuilder.AlterColumn<string>(
                name: "CIF",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Locations",
                table: "asp_Locations",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Languages",
                table: "asp_Languages",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Inventories",
                table: "asp_Inventories",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Enterprises",
                table: "asp_Enterprises",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Copies",
                table: "asp_Copies",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Centers",
                table: "asp_Centers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Categories",
                table: "asp_Categories",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Books",
                table: "asp_Books",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Bookings",
                table: "asp_Bookings",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Authors",
                table: "asp_Authors",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asp_Addresses",
                table: "asp_Addresses",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Bookings_AspNetUsers_UserID",
                table: "asp_Bookings",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Bookings_asp_Copies_CopyID",
                table: "asp_Bookings",
                column: "CopyID",
                principalTable: "asp_Copies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Books_asp_Authors_AuthorID",
                table: "asp_Books",
                column: "AuthorID",
                principalTable: "asp_Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Books_asp_Categories_CategoryID",
                table: "asp_Books",
                column: "CategoryID",
                principalTable: "asp_Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Centers_asp_Enterprises_EnterpriseID",
                table: "asp_Centers",
                column: "EnterpriseID",
                principalTable: "asp_Enterprises",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Copies_asp_Books_BookID",
                table: "asp_Copies",
                column: "BookID",
                principalTable: "asp_Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Copies_asp_Locations_LocationID",
                table: "asp_Copies",
                column: "LocationID",
                principalTable: "asp_Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Enterprises_asp_Addresses_AddressID",
                table: "asp_Enterprises",
                column: "AddressID",
                principalTable: "asp_Addresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Inventories_AspNetUsers_UserID",
                table: "asp_Inventories",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Inventories_asp_Books_BookID",
                table: "asp_Inventories",
                column: "BookID",
                principalTable: "asp_Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_Locations_asp_Centers_CenterID",
                table: "asp_Locations",
                column: "CenterID",
                principalTable: "asp_Centers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_asp_Centers_CenterID",
                table: "AspNetUsers",
                column: "CenterID",
                principalTable: "asp_Centers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_asp_Enterprises_EnterpriseID",
                table: "AspNetUsers",
                column: "EnterpriseID",
                principalTable: "asp_Enterprises",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_asp_Languages_LanguageID",
                table: "AspNetUsers",
                column: "LanguageID",
                principalTable: "asp_Languages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
