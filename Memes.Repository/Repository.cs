using Memes.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace Memes.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MemesContext _context;
        private DbSet<T> _set;

        public Repository(MemesContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }
        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            _set.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<T> GetAll()
        {
            return _set.ToList();
        }

        public T GetById(int id)
        {
            return _set.Find(id);
        }

        public T Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            _set.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            _context.SaveChanges();
            return entity;
        }

        public ICollection<T> GetByCustom(Func<T, bool> predicate)
        {
            return _set.Where(predicate).ToList();
        }


        public DbEntityEntry<T> Entry(T entity)
        {
            return _context.Entry<T>(entity);
        }

        //Async methods

        public async Task DeleteAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            _set.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _set.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _set.FindAsync(id);
        }

        public async Task<T> InsertAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            _set.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
