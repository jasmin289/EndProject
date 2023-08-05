using EndProject.API.Models.DTO;
using System.Linq.Expressions;

namespace EndProject.API.Repositories
{
    public interface IUserRepository : IReopsiteories<User>
    {
        // we are build an reposotiry for only user. the reson we do this is 
        // becuse whaen we want to update only user we use this method
    }
    public class UserRepository : IUserRepository
    {

        //and this class is implement the user repository
        public User Creat(User item)
        {
            throw new NotImplementedException();
        }

        public void Deleted(User item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> FindByCondision(Expression<Func<User, bool>> condision)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public User Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
