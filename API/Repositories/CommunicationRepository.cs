using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class CommunicationRepository : RepositoryBase<Communication>, ICommunicationRepository
    {
       public CommunicationRepository(MainContex _contex) : base(_contex)
        { }

    }
}
