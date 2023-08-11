using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;

namespace EndProject.API.Repositories
{
    public class ProjectGallryRepository : RepositoryBase<ProjectGallry>, IProjectGallryRepository
    {
        
        public ProjectGallryRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
