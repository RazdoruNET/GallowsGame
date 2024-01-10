using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GallowsGame.Migrations
{
    /// <inheritdoc />
    public partial class AddAnyLinks_001744 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GameId",
                table: "Questions",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Questions_GameId",
                table: "Questions",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Games_GameId",
                table: "Questions",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Games_GameId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_GameId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Questions");
        }
    }
}
