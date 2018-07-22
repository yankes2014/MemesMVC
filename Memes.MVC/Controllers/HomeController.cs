using AutoMapper;
using Memes.MVC.Models;
using Memes.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Memes.MVC.Controllers
{
    public class HomeController : Controller
    {

        private IPostService _postService;

        public HomeController(IPostService postService)
        {
            _postService = postService;
        }

        public ActionResult Index()
        {
            var posts = _postService.GetAll();
            var postViewModels = new HashSet<PostViewModel>();

            foreach (var p in posts)
            {
                _postService.Entry(p).Collection(f => f.Comments).Load();

                var imgSrc = "data:image;base64," + Convert.ToBase64String(p.BackgroundImage);
                var pv = new PostViewModel();

                postViewModels.Add(
                    Mapper.Map(p, pv)
                );

                pv.BackgroundImgSrc = imgSrc;
            }

            ViewData["Posts"] = postViewModels;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}