using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;

namespace EndProject.API.Repositories
{
    public class PersonalAttributesRepository : RepositoryBase<PersonalAttributes>, IPersonalAttributesRepository
    {
        public PersonalAttributesRepository(MainContex _contex) : base(_contex)
        {
        }
    }
}
