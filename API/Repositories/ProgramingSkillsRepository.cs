using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class ProgramingSkillsRepository : RepositoryBase<ProgramingSkills>, IProgramingSkillsRepository
    {
        public ProgramingSkillsRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
