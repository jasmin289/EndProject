using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndProject.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Communication",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhonNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    stsus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communication", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Started = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ended = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompnyURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompnyLogoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Started = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ended = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "General",
                columns: table => new
                {
                    Kye = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General", x => x.Kye);
                });

            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDiscription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalAttributes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalAttributes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProgramingSkills",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KnownFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Display = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramingSkills", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SocialNetWork",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialNetWork", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EducationProgramingSkills",
                columns: table => new
                {
                    EducationID = table.Column<int>(type: "int", nullable: false),
                    SkillsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationProgramingSkills", x => new { x.EducationID, x.SkillsID });
                    table.ForeignKey(
                        name: "FK_EducationProgramingSkills_Education_EducationID",
                        column: x => x.EducationID,
                        principalTable: "Education",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationProgramingSkills_ProgramingSkills_SkillsID",
                        column: x => x.SkillsID,
                        principalTable: "ProgramingSkills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingSkills",
                columns: table => new
                {
                    SkillsID = table.Column<int>(type: "int", nullable: false),
                    ProjectsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingSkills", x => new { x.SkillsID, x.ProjectsID });
                    table.ForeignKey(
                        name: "FK_ProgrammingSkills_ProgramingSkills_SkillsID",
                        column: x => x.SkillsID,
                        principalTable: "ProgramingSkills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgrammingSkills_Project_ProjectsID",
                        column: x => x.ProjectsID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectGallry",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectGallry", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProjectGallry_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProgramingSkills",
                columns: new[] { "ID", "Category", "Display", "KnownFrom", "Name" },
                values: new object[,]
                {
                    { 1, "Back end", true, new DateTime(2022, 7, 29, 16, 28, 24, 445, DateTimeKind.Local).AddTicks(3899), "C#" },
                    { 2, "Front end", true, new DateTime(2021, 7, 29, 16, 28, 24, 445, DateTimeKind.Local).AddTicks(3905), "JavaScript" },
                    { 3, "front end", true, new DateTime(2020, 7, 29, 16, 28, 24, 445, DateTimeKind.Local).AddTicks(3908), "PHP" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ID", "Description", "GitURL", "Name", "URL" },
                values: new object[,]
                {
                    { 1, "finel", "https://github.com/jasmin289/EndProject", "End Project", "jkdjkdj" },
                    { 2, "finel", "https://github.com/jasmin289/EndProject", "End Project", "jkdjkdj" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "LastLogin", "Password", "Type", "UserName" },
                values: new object[] { 1, new DateTime(2023, 7, 29, 16, 28, 24, 445, DateTimeKind.Local).AddTicks(3566), "1234", 999, "jasmin" });

            migrationBuilder.InsertData(
                table: "ProgrammingSkills",
                columns: new[] { "ProjectsID", "SkillsID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "ProjectGallry",
                columns: new[] { "ID", "Alt", "Description", "ProjectID", "Titel", "URL" },
                values: new object[] { 1, "??", "nice pic", 1, "a pic of a dog", "https://picsum.photos/id/237/200/300" });

            migrationBuilder.CreateIndex(
                name: "IX_EducationProgramingSkills_SkillsID",
                table: "EducationProgramingSkills",
                column: "SkillsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingSkills_ProjectsID",
                table: "ProgrammingSkills",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectGallry_ProjectID",
                table: "ProjectGallry",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Communication");

            migrationBuilder.DropTable(
                name: "EducationProgramingSkills");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "General");

            migrationBuilder.DropTable(
                name: "Hobby");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "PersonalAttributes");

            migrationBuilder.DropTable(
                name: "ProgrammingSkills");

            migrationBuilder.DropTable(
                name: "ProjectGallry");

            migrationBuilder.DropTable(
                name: "SocialNetWork");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "ProgramingSkills");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
