using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;

namespace EndProject.API.Repositories
{
    public class SocialNetWorkRepository : RepositoryBase<SocialNetWork>, ISocialNetWorkRepository
    {
      
        public SocialNetWorkRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
