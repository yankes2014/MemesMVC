using Memes.Model;
using System.Collections.Generic;

namespace Memes.Service.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Deletes User entity from User repo
        /// </summary>
        /// <param name="entity"></param>
        void Delete(User entity);
        /// <summary>
        /// Inserts User entity to User repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        User Insert(User entity);
        /// <summary>
        /// Updates User entity in User repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        User Update(User entity);
        /// <summary>
        /// Gets User entity from User repo with given int id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetById(int id);
        /// <summary>
        /// Gets all User entities from User repo
        /// </summary>
        /// <returns></returns>
        ICollection<User> GetAll();
    }
}
