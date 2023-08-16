using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OgrenciServis.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Parents_ParentId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ChildParent_Childs_ChildsId",
                table: "ChildParent");

            migrationBuilder.DropForeignKey(
                name: "FK_ChildParent_Parents_ParentsId",
                table: "ChildParent");

            migrationBuilder.DropForeignKey(
                name: "FK_Kinship_Parents_ParentId",
                table: "Kinship");

            migrationBuilder.DropTable(
                name: "AdressChild");

            migrationBuilder.DropTable(
                name: "Childs");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_ParentId",
                table: "Adresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parents",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Adresses");

            migrationBuilder.RenameTable(
                name: "Parents",
                newName: "Personel");

            migrationBuilder.AlterColumn<int>(
                name: "KinshipId",
                table: "Personel",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ChildId",
                table: "Personel",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginingDate",
                table: "Personel",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personel",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Personel",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Personel",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ServiceCost",
                table: "Personel",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personel",
                table: "Personel",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AdressPersonel",
                columns: table => new
                {
                    AdressesId = table.Column<int>(type: "integer", nullable: false),
                    PersonelsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdressPersonel", x => new { x.AdressesId, x.PersonelsId });
                    table.ForeignKey(
                        name: "FK_AdressPersonel_Adresses_AdressesId",
                        column: x => x.AdressesId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdressPersonel_Personel_PersonelsId",
                        column: x => x.PersonelsId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdressPersonel_PersonelsId",
                table: "AdressPersonel",
                column: "PersonelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChildParent_Personel_ChildsId",
                table: "ChildParent",
                column: "ChildsId",
                principalTable: "Personel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChildParent_Personel_ParentsId",
                table: "ChildParent",
                column: "ParentsId",
                principalTable: "Personel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kinship_Personel_ParentId",
                table: "Kinship",
                column: "ParentId",
                principalTable: "Personel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChildParent_Personel_ChildsId",
                table: "ChildParent");

            migrationBuilder.DropForeignKey(
                name: "FK_ChildParent_Personel_ParentsId",
                table: "ChildParent");

            migrationBuilder.DropForeignKey(
                name: "FK_Kinship_Personel_ParentId",
                table: "Kinship");

            migrationBuilder.DropTable(
                name: "AdressPersonel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personel",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "BeginingDate",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "ServiceCost",
                table: "Personel");

            migrationBuilder.RenameTable(
                name: "Personel",
                newName: "Parents");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Adresses",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KinshipId",
                table: "Parents",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChildId",
                table: "Parents",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parents",
                table: "Parents",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Childs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BeginingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    IndivudialNo = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: false),
                    PhoneNo = table.Column<string>(type: "text", nullable: true),
                    PhotoUrl = table.Column<string>(type: "text", nullable: true),
                    ServiceCost = table.Column<decimal>(type: "numeric", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Childs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdressChild",
                columns: table => new
                {
                    AdressesId = table.Column<int>(type: "integer", nullable: false),
                    ChildsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdressChild", x => new { x.AdressesId, x.ChildsId });
                    table.ForeignKey(
                        name: "FK_AdressChild_Adresses_AdressesId",
                        column: x => x.AdressesId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdressChild_Childs_ChildsId",
                        column: x => x.ChildsId,
                        principalTable: "Childs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_ParentId",
                table: "Adresses",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_AdressChild_ChildsId",
                table: "AdressChild",
                column: "ChildsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Parents_ParentId",
                table: "Adresses",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChildParent_Childs_ChildsId",
                table: "ChildParent",
                column: "ChildsId",
                principalTable: "Childs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChildParent_Parents_ParentsId",
                table: "ChildParent",
                column: "ParentsId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kinship_Parents_ParentId",
                table: "Kinship",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");
        }
    }
}
