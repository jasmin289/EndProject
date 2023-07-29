﻿// <auto-generated />
using System;
using EndProject.API.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EndProject.API.Migrations
{
    [DbContext(typeof(MainContex))]
    [Migration("20230729133050_seeddata")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EducationProgramingSkills", b =>
                {
                    b.Property<int>("EducationID")
                        .HasColumnType("int");

                    b.Property<int>("SkillsID")
                        .HasColumnType("int");

                    b.HasKey("EducationID", "SkillsID");

                    b.HasIndex("SkillsID");

                    b.ToTable("EducationProgramingSkills");
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.Communication", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhonNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("stsus")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Communication");
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.Education", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ended")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Started")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.Experience", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompnyLogoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompnyURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ended")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Started")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.General", b =>
                {
                    b.Property<string>("Kye")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Kye");

                    b.ToTable("General");
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.Hobby", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDiscription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hobby");
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.PersonalAttributes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PersonalAttributes");
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.ProgramingSkills", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Display")
                        .HasColumnType("bit");

                    b.Property<DateTime>("KnownFrom")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ProgramingSkills");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Category = "Back end",
                            Display = true,
                            KnownFrom = new DateTime(2022, 7, 29, 16, 30, 50, 340, DateTimeKind.Local).AddTicks(8787),
                            Name = "C#"
                        },
                        new
                        {
                            ID = 2,
                            Category = "Front end",
                            Display = true,
                            KnownFrom = new DateTime(2021, 7, 29, 16, 30, 50, 340, DateTimeKind.Local).AddTicks(8794),
                            Name = "JavaScript"
                        },
                        new
                        {
                            ID = 3,
                            Category = "front end",
                            Display = true,
                            KnownFrom = new DateTime(2020, 7, 29, 16, 30, 50, 340, DateTimeKind.Local).AddTicks(8796),
                            Name = "PHP"
                        });
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GitURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "finel",
                            GitURL = "https://github.com/jasmin289/EndProject",
                            Name = "End Project",
                            URL = "jkdjkdj"
                        },
                        new
                        {
                            ID = 2,
                            Description = "finel",
                            GitURL = "https://github.com/jasmin289/EndProject",
                            Name = "End Project",
                            URL = "jkdjkdj"
                        });
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.ProjectGallry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Alt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProjectID");

                    b.ToTable("ProjectGallry");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Alt = "??",
                            Description = "nice pic",
                            ProjectID = 1,
                            Titel = "a pic of a dog",
                            URL = "https://picsum.photos/id/237/200/300"
                        });
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.SocialNetWork", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("IconName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SocialNetWork");
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            LastLogin = new DateTime(2023, 7, 29, 16, 30, 50, 340, DateTimeKind.Local).AddTicks(8494),
                            Password = "1234",
                            Type = 999,
                            UserName = "jasmin"
                        });
                });

            modelBuilder.Entity("ProgrammingSkills", b =>
                {
                    b.Property<int>("SkillsID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsID")
                        .HasColumnType("int");

                    b.HasKey("SkillsID", "ProjectsID");

                    b.HasIndex("ProjectsID");

                    b.ToTable("ProgrammingSkills");

                    b.HasData(
                        new
                        {
                            SkillsID = 1,
                            ProjectsID = 1
                        },
                        new
                        {
                            SkillsID = 2,
                            ProjectsID = 1
                        },
                        new
                        {
                            SkillsID = 3,
                            ProjectsID = 1
                        },
                        new
                        {
                            SkillsID = 2,
                            ProjectsID = 2
                        },
                        new
                        {
                            SkillsID = 3,
                            ProjectsID = 2
                        });
                });

            modelBuilder.Entity("EducationProgramingSkills", b =>
                {
                    b.HasOne("EndProject.API.Models.DTO.Education", null)
                        .WithMany()
                        .HasForeignKey("EducationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EndProject.API.Models.DTO.ProgramingSkills", null)
                        .WithMany()
                        .HasForeignKey("SkillsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.ProjectGallry", b =>
                {
                    b.HasOne("EndProject.API.Models.DTO.Project", null)
                        .WithMany("GalleryImages")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProgrammingSkills", b =>
                {
                    b.HasOne("EndProject.API.Models.DTO.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EndProject.API.Models.DTO.ProgramingSkills", null)
                        .WithMany()
                        .HasForeignKey("SkillsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EndProject.API.Models.DTO.Project", b =>
                {
                    b.Navigation("GalleryImages");
                });
#pragma warning restore 612, 618
        }
    }
}
