using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class EducationRepository : RepositoryBase<Education>, IEducationRepository
    {
      
        public EducationRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
