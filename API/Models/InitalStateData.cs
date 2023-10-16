using EndProject.API.Models.DTO;
using EndProject.API.Repositories;

namespace EndProject.API.Models
{
    internal class InitalStateData
    {
        private InitalStateData()
        {
        }
        public List<Communication> Communication { get; private set; }
        public List<Education> Education { get; private set; }
        public List<Experience> Experience { get; private set; }
        public List<General> General { get; private set; }
        public List<Hobby> Hobby { get; private set; }
        public List<Language> Language { get; private set; }
        public List<PersonalAttributes> PersonalAttributes { get; private set; }
        public List<ProgramingSkills> ProgramingSkills { get; private set; }
        public List<Project> Project { get; private set; }
        public List<ProjectGallry> ProjectGallry { get; private set; }
        public List<SocialNetWork> SocialNetWork { get; private set; }
        public List<User> users { get; private set; }


        internal static InitalStateData Create(


            IConfiguration config,
            ICommunicationRepository CommunicationRepository,
            IEducationRepository EducationRepository,
            IExperienceRepository experienceRepository,
            IGeneralRepository generalRepository,
            IHobbyRepository hobbyRepository,
            ILanguageRepository languageRepository,
            IPersonalAttributesRepository personalAttributesRepository,
            IProgramingSkillsRepository programingSkillsRepository,
            IProjectRepository projectRepository,
            IProjectGallryRepository projectGallryRepository,
            ISocialNetWorkRepository socialNetWorkRepository,
            IUserRepository userRepository)
        { 
            InitalStateData InitalStateData = new InitalStateData();
           
            InitalStateData.Communication = CommunicationRepository.FindAll().ToList();
            InitalStateData.Education = EducationRepository.FindAll().ToList();
            InitalStateData.Experience = experienceRepository.FindAll().ToList();
            InitalStateData.General = generalRepository.FindAll().ToList();
            InitalStateData.Hobby = hobbyRepository.FindAll().ToList();
            InitalStateData.Language = languageRepository.FindAll().ToList();
            InitalStateData.PersonalAttributes = personalAttributesRepository.FindAll().ToList();
            InitalStateData.ProgramingSkills = programingSkillsRepository.FindAll().ToList();
            InitalStateData.Project = projectRepository.FindAll().ToList();
            InitalStateData.ProjectGallry = projectGallryRepository.FindAll().ToList();
            InitalStateData.SocialNetWork = socialNetWorkRepository.FindAll().ToList();
            InitalStateData.users = userRepository.FindAll().ToList();
           
            return InitalStateData; 


        }
    }
}