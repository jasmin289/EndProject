using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;

namespace EndProject.API.Repositories
{
    public class ExperienceRepository : RepositoryBase<Experience>, IExperienceRepository
    {
    
        public ExperienceRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
