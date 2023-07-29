﻿using EndProject.API.Models.DTO;
using EndProject.API.Models.DTO.enums;
using Microsoft.EntityFrameworkCore;

namespace EndProject.API.Contexts
{
    public class MainContex : DbContext
    {
        public MainContex(DbContextOptions<MainContex> _options) : base(_options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User { ID = 1, UserName = "jasmin", Password = "1234", LastLogin = DateTime.Now, Type = UserType.Admin }
                );
            modelBuilder.Entity<Project>().HasData(
               new Project { ID = 1, Name = "End Project", Description = "finel", URL = "jkdjkdj", GitURL = "https://github.com/jasmin289/EndProject" }

               );
            modelBuilder.Entity<ProjectGallry>().HasData(new ProjectGallry
            {
                ID = 1,
                ProjectID = 1,
                URL = "https://picsum.photos/id/237/200/300",
                Alt = "??",
                Titel = "a pic of a dog",
                Description = "nice pic"
            });
            modelBuilder.Entity<ProgramingSkills>().HasData(
                new ProgramingSkills { ID = 1, Name = "C#", Category = "Back end", KnownFrom = DateTime.Now.AddYears(-1), Display = true },
                new ProgramingSkills { ID = 2, Name = "JavaScript", Category = "Front end", KnownFrom = DateTime.Now.AddYears(-2), Display = true },
                new ProgramingSkills { ID = 3, Name = "PHP", Category = "front end", KnownFrom = DateTime.Now.AddYears(-3), Display = true });

            modelBuilder.Entity<Project>()
                .HasMany(p => p.Skills)
                .WithMany(s => s.Projects)
                .UsingEntity<Dictionary<int, int>>
                (
                "ProgramingSkillsProject",
                 r => r.HasOne<ProgramingSkills>().WithMany().HasForeignKey("SkillsId"),
                 l => l.HasOne<Project>().WithMany().HasForeignKey("ProjectsID"),
                 J =>
                 {
                     J.HasKey("SkillsId", "ProjectsID");
                     J.HasData(
                         new { ProjectsID = 1, SkillsId = 1 },
                         new { ProjectsID = 1, SkillsId = 2 },
                         new { ProjectsID = 1, SkillsId = 3 },
                         new { ProjectsID = 2, SkillsId = 2 },
                         new { ProjectsID = 2, SkillsId = 3 }

                   );
                 });
        }
    
        public DbSet<Communication> Communication { get; set; }
       
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<General> General { get; set; }
        public DbSet<Hobby> Hobby { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<PersonalAttributes> PersonalAttributes { get; set; }
        public DbSet<ProgramingSkills> ProgramingSkills { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<SocialNetWork> SocialNetWork { get; set; }
        public DbSet<User> User { get; set; }


    }
}