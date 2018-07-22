using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace Memes.Repository
{
    public interface IRepository<T> where T : class
    {
        void Delete(T entity);
        DbEntityEntry<T> Entry(T entity);
        ICollection<T> GetAll();
        ICollection<T> GetByCustom(Func<T, bool> predicate);
        T GetById(int id);
        ICollection<T> GetManyByCustom(Func<T, bool> predicate);
        T Insert(T entity);
        T Update(T entity);
    }
}