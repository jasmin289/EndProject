using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class HobbyRepository : RepositoryBase<Hobby>, IHobbyRepository
    {
        public HobbyRepository(MainContex _contex) : base(_contex)
        {
        }

    }
}
