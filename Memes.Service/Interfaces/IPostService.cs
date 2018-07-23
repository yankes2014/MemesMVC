using Memes.Model;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace Memes.Service.Interfaces
{
    public interface IPostService
    {
        /// <summary>
        /// Deletes Post entity from Post repo
        /// </summary>
        /// <param name="entity"></param>
        void Delete(Post entity);
        /// <summary>
        /// Inserts Post entity to Post repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Post Insert(Post entity);
        /// <summary>
        /// Updates Post entity in Post repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Post Update(Post entity);
        /// <summary>
        /// Gets top 5 Posts from Post repo with orderby likes descendings
        /// </summary>
        /// <returns></returns>
        ICollection<Post> GetTopFive();
        /// <summary>
        /// Gets Post entity from Post repo with given int id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Post GetById(int id);
        /// <summary>
        /// Gets all Post entity from Post repo
        /// </summary>
        /// <returns></returns>
        ICollection<Post> GetAll();
        /// <summary>
        /// Entry Post entity to Post repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DbEntityEntry<Post> Entry(Post entity);
    }
}
