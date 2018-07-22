using Memes.Model;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace Memes.Service.Interfaces
{
    public interface IPostService
    {
        void Delete(Post entity);
        Post Insert(Post entity);
        Post Update(Post entity);
        Post GetById(int id);
        ICollection<Post> GetAll();
        DbEntityEntry<Post> Entry(Post entity);
    }
}
