using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace Memes.Repository
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Deletes T entity from repo
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Insert T entity to repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DbEntityEntry<T> Entry(T entity);

        /// <summary>
        /// Get all items from T repo
        /// </summary>
        /// <returns></returns>
        ICollection<T> GetAll();

        /// <summary>
        /// Get all items from T repo where conditions are true
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        ICollection<T> GetByCustom(Func<T, bool> predicate);

        /// <summary>
        /// Gets one item from T repo with given int id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Inserts T item to T repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Insert(T entity);

        /// <summary>
        /// Updates T item in T repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Update(T entity);

        /// <summary>
        /// Deletes T item from T repo async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task DeleteAsync(T entity);

        /// <summary>
        /// Gets all items from T repo async
        /// </summary>
        /// <returns></returns>
        Task<ICollection<T>> GetAllAsync();

        /// <summary>
        /// Gets one item from T repo with given int id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(int id);

        /// <summary>
        /// Inserts T item to T repo async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> InsertAsync(T entity);

        /// <summary>
        /// Updates T item in T repo async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T entity);

    }
}