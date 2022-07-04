using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Tel = table.Column<string>(type: "TEXT", nullable: false),
                    Affiliation = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trials",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    LastRefreshedOn = table.Column<string>(type: "TEXT", nullable: false),
                    PublicTitle = table.Column<string>(type: "TEXT", nullable: false),
                    ScientificTitle = table.Column<string>(type: "TEXT", nullable: false),
                    Acronym = table.Column<string>(type: "TEXT", nullable: false),
                    PrimarySponsor = table.Column<string>(type: "TEXT", nullable: false),
                    DateRegistration = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateRegistration3 = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExportDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SourceRegister = table.Column<string>(type: "TEXT", nullable: false),
                    WebAddress = table.Column<string>(type: "TEXT", nullable: false),
                    RecruitmentStatus = table.Column<string>(type: "TEXT", nullable: false),
                    OtherRecords = table.Column<string>(type: "TEXT", nullable: false),
                    Inclusion_InclusionText = table.Column<string>(type: "TEXT", nullable: false),
                    Inclusion_AgeMin = table.Column<string>(type: "TEXT", nullable: false),
                    Inclusion_AgeMax = table.Column<string>(type: "TEXT", nullable: false),
                    Inclusion_Gender = table.Column<string>(type: "TEXT", nullable: false),
                    DateEnrollement = table.Column<string>(type: "TEXT", nullable: false),
                    TargetSize = table.Column<string>(type: "TEXT", nullable: false),
                    StudyType = table.Column<string>(type: "TEXT", nullable: false),
                    StudyDesign = table.Column<string>(type: "TEXT", nullable: false),
                    Phase = table.Column<string>(type: "TEXT", nullable: false),
                    Countries = table.Column<string>(type: "TEXT", nullable: false),
                    ContactId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExclusionCriteria = table.Column<string>(type: "TEXT", nullable: false),
                    Condition = table.Column<string>(type: "TEXT", nullable: false),
                    Intervention = table.Column<string>(type: "TEXT", nullable: false),
                    PrimaryOutcome = table.Column<string>(type: "TEXT", nullable: false),
                    ResultsDatePosted = table.Column<string>(type: "TEXT", nullable: false),
                    ResultsDateCompleted = table.Column<string>(type: "TEXT", nullable: false),
                    ResultsUrlLink = table.Column<string>(type: "TEXT", nullable: false),
                    Retrospective = table.Column<bool>(type: "INTEGER", nullable: false),
                    Bridging = table.Column<bool>(type: "INTEGER", nullable: false),
                    BridgedType = table.Column<string>(type: "TEXT", nullable: false),
                    Results = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trials_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trials_ContactId",
                table: "Trials",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trials");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
