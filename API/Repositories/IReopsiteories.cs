using EndProject.API.Contexts;
using System.Collections.Generic;

namespace EndProject.API.Repositories
{
    public interface IReopsiteories<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondision();

        T Creat(T item);
        
        T Update(T item);

        void Deleted(T item);

        void Save();
    }
    public class RepositoryBase<T> : IReopsiteories<T>
    {
        private readonly MainContex _context;
        public RepositoryBase(MainContex _context)
        {
            this._context = _context ?? throw new ArgumentNullException();
        }
        public T Creat(T item)
        {
            throw new NotImplementedException();
        }

        public void Deleted(T item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindByCondision()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
