using EndProject.API.Models;
using EndProject.API.Repositories;
using Microsoft.AspNetCore.Mvc;



namespace EndProject.API.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class InitalStateController : Controller
    {
        private readonly IConfiguration config;
        private readonly ICommunicationRepository CommunicationRepository;
        private readonly IEducationRepository EducationRepository;
        private readonly IExperienceRepository experienceRepository;
        private readonly IGeneralRepository generalRepository;
        private readonly IHobbyRepository hobbyRepository;
        private readonly ILanguageRepository languageRepository;
        private readonly IPersonalAttributesRepository personalAttributesRepository;
        private readonly IProgramingSkillsRepository programingSkillsRepository;
        private readonly IProjectRepository projectRepository;
        private readonly IProjectGallryRepository projectGallryRepository;
        private readonly ISocialNetWorkRepository socialNetWorkRepository;
        private readonly IUserRepository userRepository;
        private readonly IitemRepository itemRepository;
        public InitalStateController(
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
            IUserRepository userRepository,
            IitemRepository itemRepository
            )
        {
            this.config = config ?? throw new ArgumentNullException(nameof(config));
            this.CommunicationRepository = CommunicationRepository ?? throw new ArgumentNullException(nameof(CommunicationRepository));
            this.EducationRepository= EducationRepository ?? throw new ArgumentNullException( nameof(EducationRepository));
            this.experienceRepository = experienceRepository ?? throw new ArgumentNullException(nameof(experienceRepository));
            this.generalRepository = generalRepository ?? throw new ArgumentNullException(nameof(generalRepository));
            this.hobbyRepository= hobbyRepository ?? throw new ArgumentNullException(nameof(hobbyRepository));
            this.languageRepository = languageRepository ?? throw new ArgumentNullException(nameof(languageRepository));
            this.personalAttributesRepository = personalAttributesRepository ?? throw new ArgumentNullException(nameof(personalAttributesRepository));
            this.programingSkillsRepository = programingSkillsRepository ?? throw new ArgumentNullException(nameof(programingSkillsRepository));
            this.projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
            this.projectGallryRepository = projectGallryRepository ?? throw new ArgumentNullException(nameof(projectGallryRepository));
            this.socialNetWorkRepository = socialNetWorkRepository ?? throw new ArgumentNullException(nameof(socialNetWorkRepository));
            this.userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            this.itemRepository = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));
        }
        [HttpGet]
        public IActionResult GetAll()
        { 
            InitalStateData result =  InitalStateData.Create(
                config,
                CommunicationRepository,
                EducationRepository,
                experienceRepository,
                 generalRepository,
                hobbyRepository,
               languageRepository,
                personalAttributesRepository,
               programingSkillsRepository,
                projectRepository,
                projectGallryRepository,
                socialNetWorkRepository,
                userRepository,
                itemRepository

              );
          
            return Ok(result);   
        }

    }

}
