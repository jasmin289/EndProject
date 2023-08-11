using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;
using System.Linq.Expressions;

namespace EndProject.API.Repositories
{
    public interface IUserRepository : IReopsiteories<User>
    {
        // we are build an reposotiry for only user. the reson we do this is 
        // becuse whaen we want to update only user we use this method
    }
    public class UserRepository : RepositoryBase<User>,IUserRepository
    {
        //and this class is implement the user repository
        public UserRepository(MainContex _contex):base(_contex)
        {
            
        }

    }
}
