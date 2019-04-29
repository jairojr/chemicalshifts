using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChemicalShifts.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicArticles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Altered = table.Column<DateTime>(nullable: false),
                    Key = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Calibration = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: true),
                    RevisedDate = table.Column<DateTime>(nullable: true),
                    AcceptedDate = table.Column<DateTime>(nullable: true),
                    PublishedDate = table.Column<DateTime>(nullable: true),
                    Authors = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicArticles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonosaccharideUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Altered = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Formula = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonosaccharideUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Altered = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Login = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    UserType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChemicalShifts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Altered = table.Column<DateTime>(nullable: false),
                    Carbon1 = table.Column<decimal>(nullable: true),
                    Hydrogen1 = table.Column<decimal>(nullable: true),
                    Carbon2 = table.Column<decimal>(nullable: true),
                    Hydrogen2 = table.Column<decimal>(nullable: true),
                    Carbon3 = table.Column<decimal>(nullable: true),
                    Hydrogen3 = table.Column<decimal>(nullable: true),
                    Carbon4 = table.Column<decimal>(nullable: true),
                    Hydrogen4 = table.Column<decimal>(nullable: true),
                    Carbon5 = table.Column<decimal>(nullable: true),
                    Hydrogen5 = table.Column<decimal>(nullable: true),
                    Carbon6 = table.Column<decimal>(nullable: true),
                    Hydrogen6 = table.Column<decimal>(nullable: true),
                    Solvent = table.Column<string>(nullable: true),
                    Temperature = table.Column<decimal>(nullable: true),
                    MonosaccharideUnitId = table.Column<int>(nullable: false),
                    AcademicArticleId = table.Column<int>(nullable: false),
                    HSQC = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemicalShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChemicalShifts_AcademicArticles_AcademicArticleId",
                        column: x => x.AcademicArticleId,
                        principalTable: "AcademicArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChemicalShifts_MonosaccharideUnits_MonosaccharideUnitId",
                        column: x => x.MonosaccharideUnitId,
                        principalTable: "MonosaccharideUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicArticles_Id",
                table: "AcademicArticles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalShifts_AcademicArticleId",
                table: "ChemicalShifts",
                column: "AcademicArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalShifts_Id",
                table: "ChemicalShifts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalShifts_MonosaccharideUnitId",
                table: "ChemicalShifts",
                column: "MonosaccharideUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MonosaccharideUnits_Id",
                table: "MonosaccharideUnits",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                table: "Users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChemicalShifts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AcademicArticles");

            migrationBuilder.DropTable(
                name: "MonosaccharideUnits");
        }
    }
}
