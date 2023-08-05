using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class SocialNetWorkRepository : RepositoryBase<User>, ISocialNetWorkRepository
    {
      
        public SocialNetWorkRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
