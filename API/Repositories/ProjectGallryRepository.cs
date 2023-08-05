using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class ProjectGallryRepository : RepositoryBase<ProjectGallry>, IProjectGallryRepository
    {
        
        public ProjectGallryRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
