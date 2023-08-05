using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
