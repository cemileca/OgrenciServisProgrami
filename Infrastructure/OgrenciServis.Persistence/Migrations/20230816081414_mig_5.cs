using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciServis.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildParent");

            migrationBuilder.AddColumn<int>(
                name: "ChildId",
                table: "Personel",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentId1",
                table: "Personel",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personel_ChildId",
                table: "Personel",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_ParentId1",
                table: "Personel",
                column: "ParentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Personel_Personel_ChildId",
                table: "Personel",
                column: "ChildId",
                principalTable: "Personel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personel_Personel_ParentId1",
                table: "Personel",
                column: "ParentId1",
                principalTable: "Personel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personel_Personel_ChildId",
                table: "Personel");

            migrationBuilder.DropForeignKey(
                name: "FK_Personel_Personel_ParentId1",
                table: "Personel");

            migrationBuilder.DropIndex(
                name: "IX_Personel_ChildId",
                table: "Personel");

            migrationBuilder.DropIndex(
                name: "IX_Personel_ParentId1",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "ParentId1",
                table: "Personel");

            migrationBuilder.CreateTable(
                name: "ChildParent",
                columns: table => new
                {
                    ChildsId = table.Column<int>(type: "integer", nullable: false),
                    ParentsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildParent", x => new { x.ChildsId, x.ParentsId });
                    table.ForeignKey(
                        name: "FK_ChildParent_Personel_ChildsId",
                        column: x => x.ChildsId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildParent_Personel_ParentsId",
                        column: x => x.ParentsId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildParent_ParentsId",
                table: "ChildParent",
                column: "ParentsId");
        }
    }
}
