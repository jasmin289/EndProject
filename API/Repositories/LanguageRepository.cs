using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
    {
      
        public LanguageRepository(MainContex _contex) : base(_contex)
        {

        }

    }
}
