using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;

namespace EndProject.API.Repositories
{
    public class ProgramingSkillsRepository : RepositoryBase<ProgramingSkills>, IProgramingSkillsRepository
    {
        public ProgramingSkillsRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
