using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Majales.Migrations
{
    public partial class addingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classifications_Values_ValueId",
                table: "Classifications");

            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.DropIndex(
                name: "IX_Majles_ClassificationId",
                table: "Majles");

            migrationBuilder.DropIndex(
                name: "IX_Classifications_ValueId",
                table: "Classifications");

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

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Majles");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Classifications");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "Comments",
                newName: "CommentText");

            migrationBuilder.RenameColumn(
                name: "ValueId",
                table: "Classifications",
                newName: "Sec_outCost");

            migrationBuilder.AddColumn<int>(
                name: "CEO_inCost",
                table: "Classifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CEO_outCost",
                table: "Classifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MSec_inCost",
                table: "Classifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MSec_outCost",
                table: "Classifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MajlesTypeId",
                table: "Classifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mem_inCost",
                table: "Classifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mem_outCost",
                table: "Classifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sec_inCost",
                table: "Classifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MajlesTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajlesTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Majles_ClassificationId",
                table: "Majles",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Classifications_MajlesTypeId",
                table: "Classifications",
                column: "MajlesTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classifications_MajlesTypes_MajlesTypeId",
                table: "Classifications",
                column: "MajlesTypeId",
                principalTable: "MajlesTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classifications_MajlesTypes_MajlesTypeId",
                table: "Classifications");

            migrationBuilder.DropTable(
                name: "MajlesTypes");

            migrationBuilder.DropIndex(
                name: "IX_Majles_ClassificationId",
                table: "Majles");

            migrationBuilder.DropIndex(
                name: "IX_Classifications_MajlesTypeId",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "CEO_inCost",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "CEO_outCost",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "MSec_inCost",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "MSec_outCost",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "MajlesTypeId",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "Mem_inCost",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "Mem_outCost",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "Sec_inCost",
                table: "Classifications");

            migrationBuilder.RenameColumn(
                name: "CommentText",
                table: "Comments",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "Sec_outCost",
                table: "Classifications",
                newName: "ValueId");

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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Majles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Classifications",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CEO_inCost = table.Column<int>(nullable: false),
                    CEO_outCost = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MSec_inCost = table.Column<int>(nullable: false),
                    MSec_outCost = table.Column<int>(nullable: false),
                    Mem_inCost = table.Column<int>(nullable: false),
                    Mem_outCost = table.Column<int>(nullable: false),
                    Sec_inCost = table.Column<int>(nullable: false),
                    Sec_outCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Majles_ClassificationId",
                table: "Majles",
                column: "ClassificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classifications_ValueId",
                table: "Classifications",
                column: "ValueId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classifications_Values_ValueId",
                table: "Classifications",
                column: "ValueId",
                principalTable: "Values",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
