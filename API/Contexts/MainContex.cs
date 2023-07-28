using EndProject.API.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace EndProject.API.Contexts
{
    public class MainContex :DbContext
    {
        public MainContex(DbContextOptions<MainContex> _options):base (_options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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
