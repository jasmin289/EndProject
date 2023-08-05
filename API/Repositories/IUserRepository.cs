using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using System.Linq.Expressions;

namespace EndProject.API.Repositories
{
    public interface IUserRepository : IReopsiteories<User>
    {
        // we are build an reposotiry for only user. the reson we do this is 
        // becuse whaen we want to update only user we use this method
    }
    public class UserRepository : RepositoryBase<User>,IUserRepository
    {
        //and this class is implement the user repository
        public UserRepository(MainContex _contex):base(_contex)
        {
            
        }

    }
    public interface ICommunicationRepository : IReopsiteories<Communication>
    {}
    public class CommunicationRepository : RepositoryBase<Communication>, ICommunicationRepository
    {
       public CommunicationRepository(MainContex _contex) : base(_contex)
        { }

    }
    public interface IEducationRepository : IReopsiteories<Education>
    {

    }
    public class EducationRepository : RepositoryBase<Education>, IEducationRepository
    {
      
        public EducationRepository(MainContex _contex) : base(_contex)
        {

        }

    }
    public interface IExperienceRepository : IReopsiteories<Experience>
    {
      
    }
    public class ExperienceRepository : RepositoryBase<Experience>, IExperienceRepository
    {
    
        public ExperienceRepository(MainContex _contex) : base(_contex)
        {

        }

    }
    public interface IGeneralRepository : IReopsiteories<General>
    {
        
    }
    public class GeneralRepository : RepositoryBase<General>, IGeneralRepository
    {
       
        public GeneralRepository(MainContex _contex) : base(_contex)
        {

        }

    }
    public interface IHobbyRepository : IReopsiteories<Hobby>
    { }
    public class HobbyRepository : RepositoryBase<Hobby>, IHobbyRepository
    {
        public HobbyRepository(MainContex _contex) : base(_contex)
        {
        }

    }
    public interface ILanguageRepository : IReopsiteories<Language>
    {

    }
    public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
    {
      
        public LanguageRepository(MainContex _contex) : base(_contex)
        {

        }

    }
    public interface IPersonalAttributesRepository : IReopsiteories<PersonalAttributes>
    {
    }
    public class PersonalAttributesRepository : RepositoryBase<PersonalAttributes>, IPersonalAttributesRepository
    {
        public PersonalAttributesRepository(MainContex _contex) : base(_contex)
        {
        }
    }
    public interface IProgramingSkillsRepository : IReopsiteories<ProgramingSkills>
    {
       
    }
    public class ProgramingSkillsRepository : RepositoryBase<ProgramingSkills>, IProgramingSkillsRepository
    {
        public ProgramingSkillsRepository(MainContex _contex) : base(_contex)
        {

        }

    }
    public interface IProjectRepository : IReopsiteories<Project>
    {
    }
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(MainContex _contex) : base(_contex)
        {

        }

    }
    public interface IProjectGallryRepository : IReopsiteories<ProjectGallry>
    {
 
    }
    public class ProjectGallryRepository : RepositoryBase<ProjectGallry>, IProjectGallryRepository
    {
        
        public ProjectGallryRepository(MainContex _contex) : base(_contex)
        {

        }

    }
    public interface ISocialNetWorkRepository : IReopsiteories<User>
    {
    }
    public class SocialNetWorkRepository : RepositoryBase<User>, ISocialNetWorkRepository
    {
      
        public SocialNetWorkRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
