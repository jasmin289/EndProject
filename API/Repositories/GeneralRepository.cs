using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class GeneralRepository : RepositoryBase<General>, IGeneralRepository
    {
       
        public GeneralRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
