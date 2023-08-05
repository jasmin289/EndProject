using EndProject.API.Contexts;
using EndProject.API.Models.DTO;

namespace EndProject.API.Repositories
{
    public class PersonalAttributesRepository : RepositoryBase<PersonalAttributes>, IPersonalAttributesRepository
    {
        public PersonalAttributesRepository(MainContex _contex) : base(_contex)
        {
        }
    }
}
