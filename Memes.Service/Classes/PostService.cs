using Memes.Model;
using Memes.Repository;
using Memes.Service.Interfaces;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Memes.Service.Classes
{
    public class PostService : IPostService
    {
        private IRepository<Post> _repository;

        public PostService(IRepository<Post> repository)
        {
            _repository = repository;
        }

        public void Delete(Post entity)
        {
            _repository.Delete(entity);
        }

        public DbEntityEntry<Post> Entry(Post entity)
        {
            return _repository.Entry(entity);
        }

        public ICollection<Post> GetAll()
        {
            return _repository.GetAll();
        }

        public ICollection<Post> GetTopFive()
        {
            var str = _repository.GetAll();
            str.OrderByDescending(p => p.Likes);

            return str.OrderByDescending(p => p.Likes).ToList().Take(5).ToList();
        }

        public Post GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Post Insert(Post entity)
        {
            return _repository.Insert(entity);
        }

        public Post Update(Post entity)
        {
            return _repository.Update(entity);
        }
    }
}
