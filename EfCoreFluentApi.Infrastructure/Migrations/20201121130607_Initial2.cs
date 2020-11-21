using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreFluentApi.Infrastructure.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apps_AppSettings_SettingsId",
                table: "Apps");

            migrationBuilder.DropIndex(
                name: "IX_Apps_SettingsId",
                table: "Apps");

            migrationBuilder.DropColumn(
                name: "SettingsId",
                table: "Apps");

            migrationBuilder.AddForeignKey(
                name: "FK_Apps_AppSettings_Id",
                table: "Apps",
                column: "Id",
                principalTable: "AppSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apps_AppSettings_Id",
                table: "Apps");

            migrationBuilder.AddColumn<Guid>(
                name: "SettingsId",
                table: "Apps",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Apps_SettingsId",
                table: "Apps",
                column: "SettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apps_AppSettings_SettingsId",
                table: "Apps",
                column: "SettingsId",
                principalTable: "AppSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
