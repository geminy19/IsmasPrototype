using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsmasPrototype.Migrations
{
    /// <inheritdoc />
    public partial class ExpandStudentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastNameLatin",
                table: "Students",
                newName: "UniversityName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "UniversityCountry");

            migrationBuilder.RenameColumn(
                name: "IdentificationNumber",
                table: "Students",
                newName: "UniversityCity");

            migrationBuilder.RenameColumn(
                name: "FirstNameLatin",
                table: "Students",
                newName: "PhoneCountryCode");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Students",
                newName: "PermanentPostalCode");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthCity",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BirthCountry",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CitizenshipCountry",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CurrentApartment",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentBlock",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentCity",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentCountry",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CurrentDistrict",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentEntrance",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentFloor",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentPostalCode",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CurrentStreet",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentStreetNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentVillage",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeType",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyFirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyLastName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyPhoneCountryCode",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyPhoneNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstNameBg",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstNameEn",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasAppliedForVisaBefore",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasPreviousEducation",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "IdCardIssueDate",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdCardIssuedBy",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdCardNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastNameBg",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastNameEn",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleNameBg",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleNameEn",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalIdNumber",
                table: "Students",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PassportIssueDate",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentApartment",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentBlock",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentCity",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentCountry",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PermanentDistrict",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentEntrance",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentFloor",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentStreet",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentStreetNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentVillage",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousDegreeType",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousEducationPeriod",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviousJ1VisaCount",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousMajor",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousUniversityName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousVisaNotes",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UniversityEndDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UniversityStartDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BirthCity",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BirthCountry",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CitizenshipCountry",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentApartment",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentBlock",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentCity",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentCountry",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentDistrict",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentEntrance",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentFloor",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentPostalCode",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentStreet",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentStreetNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentVillage",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DegreeType",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "EmergencyFirstName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "EmergencyLastName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "EmergencyPhoneCountryCode",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "EmergencyPhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FirstNameBg",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FirstNameEn",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "HasAppliedForVisaBefore",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "HasPreviousEducation",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IdCardIssueDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IdCardIssuedBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IdCardNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastNameBg",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastNameEn",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MiddleNameBg",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MiddleNameEn",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "NationalIdNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PassportIssueDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentApartment",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentBlock",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentCity",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentCountry",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentDistrict",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentEntrance",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentFloor",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentStreet",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentStreetNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentVillage",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PreviousDegreeType",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PreviousEducationPeriod",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PreviousJ1VisaCount",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PreviousMajor",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PreviousUniversityName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PreviousVisaNotes",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UniversityEndDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UniversityStartDate",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "UniversityName",
                table: "Students",
                newName: "LastNameLatin");

            migrationBuilder.RenameColumn(
                name: "UniversityCountry",
                table: "Students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "UniversityCity",
                table: "Students",
                newName: "IdentificationNumber");

            migrationBuilder.RenameColumn(
                name: "PhoneCountryCode",
                table: "Students",
                newName: "FirstNameLatin");

            migrationBuilder.RenameColumn(
                name: "PermanentPostalCode",
                table: "Students",
                newName: "FirstName");
        }
    }
}
