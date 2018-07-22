using AutoMapper;
using Memes.Model;
using Memes.MVC.Models;

namespace Memes.MVC.App_Start
{
    public class AutomapperConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>()
                    .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Username))
                    .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments.Count));
                cfg.CreateMap<Comment, CommentViewModel>()
                    .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Username));
            }
            );
        }
    }
}