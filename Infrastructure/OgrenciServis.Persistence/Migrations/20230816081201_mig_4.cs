using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciServis.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "KinshipId",
                table: "Personel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChildId",
                table: "Personel",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KinshipId",
                table: "Personel",
                type: "integer",
                nullable: true);
        }
    }
}
