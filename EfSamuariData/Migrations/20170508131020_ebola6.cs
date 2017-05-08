using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EfSamuariData.Migrations
{
    public partial class ebola6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BattleLogId",
                table: "Battle",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BattleLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BattleEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BattleLogId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Event = table.Column<string>(nullable: true),
                    EventTime = table.Column<DateTime>(nullable: false),
                    SamuraiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleEvents", x => x.Id);
                    table.UniqueConstraint("AK_BattleEvents_SamuraiId_EventTime", x => new { x.SamuraiId, x.EventTime });
                    table.ForeignKey(
                        name: "FK_BattleEvents_BattleLogs_BattleLogId",
                        column: x => x.BattleLogId,
                        principalTable: "BattleLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleEvents_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battle_BattleLogId",
                table: "Battle",
                column: "BattleLogId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleEvents_BattleLogId",
                table: "BattleEvents",
                column: "BattleLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battle_BattleLogs_BattleLogId",
                table: "Battle",
                column: "BattleLogId",
                principalTable: "BattleLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battle_BattleLogs_BattleLogId",
                table: "Battle");

            migrationBuilder.DropTable(
                name: "BattleEvents");

            migrationBuilder.DropTable(
                name: "BattleLogs");

            migrationBuilder.DropIndex(
                name: "IX_Battle_BattleLogId",
                table: "Battle");

            migrationBuilder.DropColumn(
                name: "BattleLogId",
                table: "Battle");
        }
    }
}
