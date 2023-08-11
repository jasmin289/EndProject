using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;

namespace EndProject.API.Repositories
{
    public class CommunicationRepository : RepositoryBase<Communication>, ICommunicationRepository
    {
       public CommunicationRepository(MainContex _contex) : base(_contex)
        { }

    }
}
