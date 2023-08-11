using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;

namespace EndProject.API.Repositories
{
    public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
    {
      
        public LanguageRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
