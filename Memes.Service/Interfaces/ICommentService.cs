using Memes.Model;

namespace Memes.Service.Interfaces
{
    public interface ICommentService
    {
        /// <summary>
        /// Deletes Comment entity from Comment repo
        /// </summary>
        /// <param name="entity"></param>
        void Delete(Comment entity);
        /// <summary>
        /// Inserts Comment entity to Comment repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Comment Insert(Comment entity);
        /// <summary>
        /// Updates Comment entity in Comment repo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Comment Update(Comment entity);
        /// <summary>
        /// Gets comment entity from Comment repo with given int id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Comment GetById(int id);
    }
}
