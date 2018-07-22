using Memes.DataAccessLayer;
using Memes.Model;
using Memes.Repository;
using Memes.Service.Classes;
using Memes.Service.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Memes.MVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<MemesContext>();

            container.RegisterType<IRepository<User>, Repository<User>>();
            container.RegisterType<IRepository<Comment>, Repository<Comment>>();
            container.RegisterType<IRepository<Post>, Repository<Post>>();

            container.RegisterType<IPostService, PostService>();
            container.RegisterType<ICommentService, CommentService>();
            container.RegisterType<IUserService, UserService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}