using Memes.Model;

namespace Memes.Service.Interfaces
{
    public interface ICommentService
    {
        void Delete(Comment entity);
        Comment Insert(Comment entity);
        Comment Update(Comment entity);
        Comment GetById(int id);
    }
}
