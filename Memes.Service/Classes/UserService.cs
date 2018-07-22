using Memes.Model;
using Memes.Repository;
using Memes.Service.Interfaces;
using System.Collections.Generic;

namespace Memes.Service.Classes
{
    public class UserService : IUserService
    {
        private IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public void Delete(User entity)
        {
            _repository.Delete(entity);
        }

        public ICollection<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetById(int id)
        {
            return _repository.GetById(id);
        }

        public User Insert(User entity)
        {
            return _repository.Insert(entity);
        }

        public User Update(User entity)
        {
            return _repository.Update(entity);
        }
    }
}
