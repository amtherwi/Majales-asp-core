using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Majales.Migrations
{
    public partial class addingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveStatus",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "EnrolledDate",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Members");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ActiveStatus",
                table: "Members",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EnrolledDate",
                table: "Members",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Members",
                nullable: true);
        }
    }
}
