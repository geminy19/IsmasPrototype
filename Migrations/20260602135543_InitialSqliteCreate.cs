using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsmasPrototype.Migrations
{
    /// <inheritdoc />
    public partial class InitialSqliteCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstNameBg = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleNameBg = table.Column<string>(type: "TEXT", nullable: false),
                    LastNameBg = table.Column<string>(type: "TEXT", nullable: false),
                    FirstNameEn = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleNameEn = table.Column<string>(type: "TEXT", nullable: false),
                    LastNameEn = table.Column<string>(type: "TEXT", nullable: false),
                    CitizenshipCountry = table.Column<string>(type: "TEXT", nullable: false),
                    IdCardNumber = table.Column<string>(type: "TEXT", nullable: true),
                    IdCardIssueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IdCardIssuedBy = table.Column<string>(type: "TEXT", nullable: true),
                    PassportNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PassportIssueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NationalIdNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    MaritalStatus = table.Column<string>(type: "TEXT", nullable: false),
                    BirthCity = table.Column<string>(type: "TEXT", nullable: false),
                    BirthCountry = table.Column<string>(type: "TEXT", nullable: false),
                    Nationality = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneCountryCode = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PermanentCountry = table.Column<string>(type: "TEXT", nullable: false),
                    PermanentCity = table.Column<string>(type: "TEXT", nullable: true),
                    PermanentVillage = table.Column<string>(type: "TEXT", nullable: true),
                    PermanentPostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    PermanentDistrict = table.Column<string>(type: "TEXT", nullable: true),
                    PermanentStreet = table.Column<string>(type: "TEXT", nullable: true),
                    PermanentStreetNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PermanentBlock = table.Column<string>(type: "TEXT", nullable: true),
                    PermanentEntrance = table.Column<string>(type: "TEXT", nullable: true),
                    PermanentFloor = table.Column<string>(type: "TEXT", nullable: true),
                    PermanentApartment = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentCountry = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentCity = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentVillage = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentPostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentDistrict = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentStreet = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentStreetNumber = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentBlock = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentEntrance = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentFloor = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentApartment = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    EmergencyLastName = table.Column<string>(type: "TEXT", nullable: false),
                    EmergencyPhoneCountryCode = table.Column<string>(type: "TEXT", nullable: false),
                    EmergencyPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    UniversityCountry = table.Column<string>(type: "TEXT", nullable: false),
                    UniversityCity = table.Column<string>(type: "TEXT", nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", nullable: false),
                    Major = table.Column<string>(type: "TEXT", nullable: false),
                    UniversityStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UniversityEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DegreeType = table.Column<string>(type: "TEXT", nullable: false),
                    HasPreviousEducation = table.Column<bool>(type: "INTEGER", nullable: false),
                    PreviousUniversityName = table.Column<string>(type: "TEXT", nullable: true),
                    PreviousMajor = table.Column<string>(type: "TEXT", nullable: true),
                    PreviousEducationPeriod = table.Column<string>(type: "TEXT", nullable: true),
                    PreviousDegreeType = table.Column<string>(type: "TEXT", nullable: true),
                    HasAppliedForVisaBefore = table.Column<bool>(type: "INTEGER", nullable: false),
                    PreviousJ1VisaCount = table.Column<int>(type: "INTEGER", nullable: true),
                    PreviousVisaNotes = table.Column<string>(type: "TEXT", nullable: true),
                    Season = table.Column<int>(type: "INTEGER", nullable: false),
                    Office = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Sponsor = table.Column<string>(type: "TEXT", nullable: false),
                    Employer = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    Season = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    PaymentType = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_StudentId",
                table: "Payments",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "WorkLists");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
