using Memes.Model;
using Memes.Repository;
using Memes.Service.Interfaces;

namespace Memes.Service.Classes
{
    public class CommentService : ICommentService
    {
        private IRepository<Comment> _repository;

        public CommentService(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public void Delete(Comment entity)
        {
            _repository.Delete(entity);
        }

        public Comment GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Comment Insert(Comment entity)
        {
            return _repository.Insert(entity);
        }

        public Comment Update(Comment entity)
        {
            return _repository.Update(entity);
        }
    }
}
