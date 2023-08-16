using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciServis.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "District",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistrictDescription",
                table: "District",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistrictName",
                table: "District",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Country",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UlkeCountryCode",
                table: "Country",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityDescription",
                table: "City",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "City",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "City",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_District_CityId",
                table: "District",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_District_City_CityId",
                table: "District",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_District_City_CityId",
                table: "District");

            migrationBuilder.DropIndex(
                name: "IX_District_CityId",
                table: "District");

            migrationBuilder.DropIndex(
                name: "IX_City_CountryId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "District");

            migrationBuilder.DropColumn(
                name: "DistrictDescription",
                table: "District");

            migrationBuilder.DropColumn(
                name: "DistrictName",
                table: "District");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "UlkeCountryCode",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "CityDescription",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "City");
        }
    }
}
