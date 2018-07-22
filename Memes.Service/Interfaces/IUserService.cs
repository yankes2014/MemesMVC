using Memes.Model;
using System.Collections.Generic;

namespace Memes.Service.Interfaces
{
    public interface IUserService
    {
        void Delete(User entity);
        User Insert(User entity);
        User Update(User entity);
        User GetById(int id);
        ICollection<User> GetAll();
    }
}
