using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;

namespace EndProject.API.Repositories
{
    public class EducationRepository : RepositoryBase<Education>, IEducationRepository
    {
      
        public EducationRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
