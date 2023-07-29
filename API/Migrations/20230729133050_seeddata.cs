using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndProject.API.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProgramingSkills",
                keyColumn: "ID",
                keyValue: 1,
                column: "KnownFrom",
                value: new DateTime(2022, 7, 29, 16, 30, 50, 340, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "ProgramingSkills",
                keyColumn: "ID",
                keyValue: 2,
                column: "KnownFrom",
                value: new DateTime(2021, 7, 29, 16, 30, 50, 340, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "ProgramingSkills",
                keyColumn: "ID",
                keyValue: 3,
                column: "KnownFrom",
                value: new DateTime(2020, 7, 29, 16, 30, 50, 340, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2023, 7, 29, 16, 30, 50, 340, DateTimeKind.Local).AddTicks(8494));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProgramingSkills",
                keyColumn: "ID",
                keyValue: 1,
                column: "KnownFrom",
                value: new DateTime(2022, 7, 29, 16, 28, 24, 445, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "ProgramingSkills",
                keyColumn: "ID",
                keyValue: 2,
                column: "KnownFrom",
                value: new DateTime(2021, 7, 29, 16, 28, 24, 445, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ProgramingSkills",
                keyColumn: "ID",
                keyValue: 3,
                column: "KnownFrom",
                value: new DateTime(2020, 7, 29, 16, 28, 24, 445, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                column: "LastLogin",
                value: new DateTime(2023, 7, 29, 16, 28, 24, 445, DateTimeKind.Local).AddTicks(3566));
        }
    }
}
