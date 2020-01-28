using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Majales.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MajlisMembership_MembershipRole_RoleId",
                table: "MajlisMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingMinutes_Members_MemberId",
                table: "MeetingMinutes");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Majles_MajlesId",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Members_MemberId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_MemberId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_TopicId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Topics_ClassificationId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_MajlisMembership_RoleId",
                table: "MajlisMembership");

            migrationBuilder.DropIndex(
                name: "IX_Majles_MajlesTypeId",
                table: "Majles");

            migrationBuilder.DropIndex(
                name: "IX_Classifications_MajlesTypeId",
                table: "Classifications");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_MeetingId",
                table: "Attendances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembershipRole",
                table: "MembershipRole");

            migrationBuilder.DropColumn(
                name: "CEOid",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Majles");

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
                name: "Mem_inCost",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "Mem_outCost",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "Sec_inCost",
                table: "Classifications");

            migrationBuilder.RenameTable(
                name: "MembershipRole",
                newName: "MembershipRoles");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Votes",
                newName: "abstentResult");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Meetings",
                newName: "MeetingDate");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "MajlisMembership",
                newName: "JoinDate");

            migrationBuilder.RenameColumn(
                name: "Sec_outCost",
                table: "Classifications",
                newName: "ValueId");

            migrationBuilder.AddColumn<int>(
                name: "NoResult",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YesResult",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ActiveStatus",
                table: "Members",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EnrolledDate",
                table: "Members",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MemberEmail",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberName",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Members",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MajlesId",
                table: "Meetings",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "MeetingMinutes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassificationId",
                table: "Majles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentMajlesId",
                table: "Majles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassificationType",
                table: "Classifications",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembershipRoles",
                table: "MembershipRoles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Values",
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
                    CEOinCost = table.Column<float>(nullable: true),
                    CEOoutCost = table.Column<float>(nullable: true),
                    SecinCost = table.Column<float>(nullable: true),
                    SecoutCost = table.Column<float>(nullable: true),
                    MSecinCost = table.Column<float>(nullable: true),
                    MSecoutCost = table.Column<float>(nullable: true),
                    MeminCost = table.Column<float>(nullable: true),
                    MemoutCost = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoteTransactions",
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
                    VoteValue = table.Column<int>(nullable: false),
                    VoteId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteTransactions_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoteTransactions_Votes_VoteId",
                        column: x => x.VoteId,
                        principalTable: "Votes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Votes_TopicId",
                table: "Votes",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ClassificationId",
                table: "Topics",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_MajlisMembership_RoleId",
                table: "MajlisMembership",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Majles_ClassificationId",
                table: "Majles",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Majles_MajlesTypeId",
                table: "Majles",
                column: "MajlesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Majles_ParentMajlesId",
                table: "Majles",
                column: "ParentMajlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Classifications_MajlesTypeId",
                table: "Classifications",
                column: "MajlesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Classifications_ValueId",
                table: "Classifications",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_MeetingId",
                table: "Attendances",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteTransactions_MemberId",
                table: "VoteTransactions",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteTransactions_VoteId",
                table: "VoteTransactions",
                column: "VoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classifications_Values_ValueId",
                table: "Classifications",
                column: "ValueId",
                principalTable: "Values",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Majles_Classifications_ClassificationId",
                table: "Majles",
                column: "ClassificationId",
                principalTable: "Classifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Majles_Majles_ParentMajlesId",
                table: "Majles",
                column: "ParentMajlesId",
                principalTable: "Majles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MajlisMembership_MembershipRoles_RoleId",
                table: "MajlisMembership",
                column: "RoleId",
                principalTable: "MembershipRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingMinutes_Members_MemberId",
                table: "MeetingMinutes",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Majles_MajlesId",
                table: "Meetings",
                column: "MajlesId",
                principalTable: "Majles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classifications_Values_ValueId",
                table: "Classifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Majles_Classifications_ClassificationId",
                table: "Majles");

            migrationBuilder.DropForeignKey(
                name: "FK_Majles_Majles_ParentMajlesId",
                table: "Majles");

            migrationBuilder.DropForeignKey(
                name: "FK_MajlisMembership_MembershipRoles_RoleId",
                table: "MajlisMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingMinutes_Members_MemberId",
                table: "MeetingMinutes");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Majles_MajlesId",
                table: "Meetings");

            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.DropTable(
                name: "VoteTransactions");

            migrationBuilder.DropIndex(
                name: "IX_Votes_TopicId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Topics_ClassificationId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_MajlisMembership_RoleId",
                table: "MajlisMembership");

            migrationBuilder.DropIndex(
                name: "IX_Majles_ClassificationId",
                table: "Majles");

            migrationBuilder.DropIndex(
                name: "IX_Majles_MajlesTypeId",
                table: "Majles");

            migrationBuilder.DropIndex(
                name: "IX_Majles_ParentMajlesId",
                table: "Majles");

            migrationBuilder.DropIndex(
                name: "IX_Classifications_MajlesTypeId",
                table: "Classifications");

            migrationBuilder.DropIndex(
                name: "IX_Classifications_ValueId",
                table: "Classifications");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_MeetingId",
                table: "Attendances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembershipRoles",
                table: "MembershipRoles");

            migrationBuilder.DropColumn(
                name: "NoResult",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "YesResult",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "ActiveStatus",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "EnrolledDate",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MemberEmail",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MemberName",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "ClassificationId",
                table: "Majles");

            migrationBuilder.DropColumn(
                name: "ParentMajlesId",
                table: "Majles");

            migrationBuilder.DropColumn(
                name: "ClassificationType",
                table: "Classifications");

            migrationBuilder.RenameTable(
                name: "MembershipRoles",
                newName: "MembershipRole");

            migrationBuilder.RenameColumn(
                name: "abstentResult",
                table: "Votes",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "MeetingDate",
                table: "Meetings",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "JoinDate",
                table: "MajlisMembership",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ValueId",
                table: "Classifications",
                newName: "Sec_outCost");

            migrationBuilder.AlterColumn<int>(
                name: "MajlesId",
                table: "Meetings",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CEOid",
                table: "Meetings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Meetings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "MeetingMinutes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Majles",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembershipRole",
                table: "MembershipRole",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_MemberId",
                table: "Votes",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_TopicId",
                table: "Votes",
                column: "TopicId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ClassificationId",
                table: "Topics",
                column: "ClassificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MajlisMembership_RoleId",
                table: "MajlisMembership",
                column: "RoleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Majles_MajlesTypeId",
                table: "Majles",
                column: "MajlesTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classifications_MajlesTypeId",
                table: "Classifications",
                column: "MajlesTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_MeetingId",
                table: "Attendances",
                column: "MeetingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MajlisMembership_MembershipRole_RoleId",
                table: "MajlisMembership",
                column: "RoleId",
                principalTable: "MembershipRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingMinutes_Members_MemberId",
                table: "MeetingMinutes",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Majles_MajlesId",
                table: "Meetings",
                column: "MajlesId",
                principalTable: "Majles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Members_MemberId",
                table: "Votes",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
