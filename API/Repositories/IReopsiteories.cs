using EndProject.API.Contexts;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EndProject.API.Repositories
{
    public interface IReopsiteories<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondision(Expression<Func<T, bool>> condision);

        T Creat(T item);
        
        T Update(T item);

        void Deleted(T item);

        void Save();
    }
    public class RepositoryBase<T> : IReopsiteories<T>where T : class
    {
        // T most be a type of class ,we can't put an int type - for example.
        private readonly MainContex _context;
        public RepositoryBase(MainContex _context)
        {
            this._context = _context ?? throw new ArgumentNullException(nameof(_context));
        }
        public T Creat(T item)
        {
            // find the table that you use and add this item
            EntityEntry<T> newItem = _context.Set<T>().Add(item);
            Save();
            return newItem.Entity ;
        }

        public void Deleted(T item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
           return _context.Set<T>();
        }


        // get a condision that come as an func and the find by this condision 
        public IQueryable<T> FindByCondision(Expression<Func<T,bool>> condision)
        {
            return _context.Set<T>().Where(condision);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public T Update(T item)
        {
            EntityEntry<T> updateItem = _context.Set<T>().Update(item);
            Save();
            return updateItem.Entity ;

        }
    }
}
