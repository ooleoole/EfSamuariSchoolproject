using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamuariData.Migrations
{
    public partial class röven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Clan",
                table: "Samurais",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasSword",
                table: "Samurais",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clan",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "HasSword",
                table: "Samurais");
        }
    }
}
