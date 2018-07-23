using AutoMapper;
using Memes.MVC.Models;
using Memes.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Memes.MVC.Controllers
{
    public class StatisticController : Controller
    {
        private IPostService _postService;

        public StatisticController(IPostService postService)
        {
            _postService = postService;
        }


        // GET: Statistic
        public ActionResult Index()
        {
            var posts = _postService.GetTopFive();
            //Stworzyc metody do wyciagania top5 z najwieksza liczba komentarzy
            //Stworzyc losowanie jednego mema
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


            ViewData["TopFivePosts"] = postViewModels;

            return View();
        }

        /// <summary>
        /// Adds like to post with given int id
        /// </summary>
        /// <param name="numerek"></param>
        /// <returns></returns>
        [HttpPost]
        public RedirectResult Like(int numerek)
        {
            var post = _postService.GetById(numerek);
            post.Likes += 1;
            _postService.Update(post);

            return Redirect("/Statistic/Index");
        }
    }
}