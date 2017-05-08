using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EfSamuariData.Migrations
{
    public partial class ebola3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quote",
                table: "Quote");

            migrationBuilder.RenameTable(
                name: "Quote",
                newName: "Quotes");

            migrationBuilder.RenameIndex(
                name: "IX_Quote_SamuraiId",
                table: "Quotes",
                newName: "IX_Quotes_SamuraiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Battle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descrpition = table.Column<string>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    StarTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SamuariBattles",
                columns: table => new
                {
                    BattleId = table.Column<int>(nullable: false),
                    SamuraiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamuariBattles", x => new { x.BattleId, x.SamuraiId });
                    table.ForeignKey(
                        name: "FK_SamuariBattles_Battle_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SamuariBattles_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SamuariBattles_SamuraiId",
                table: "SamuariBattles",
                column: "SamuraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes");

            migrationBuilder.DropTable(
                name: "SamuariBattles");

            migrationBuilder.DropTable(
                name: "Battle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes");

            migrationBuilder.RenameTable(
                name: "Quotes",
                newName: "Quote");

            migrationBuilder.RenameIndex(
                name: "IX_Quotes_SamuraiId",
                table: "Quote",
                newName: "IX_Quote_SamuraiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quote",
                table: "Quote",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Samurais_SamuraiId",
                table: "Quote",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
