using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class ExperienceRepository : RepositoryBase<Experience>, IExperienceRepository
    {
    
        public ExperienceRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
