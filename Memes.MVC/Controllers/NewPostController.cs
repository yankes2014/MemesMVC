using Memes.Model;
using Memes.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Memes.MVC.Controllers
{
    public class NewPostController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        private IPostService _postService;

        public NewPostController(IPostService postService)
        {
            _postService = postService;
        }


        /// <summary>
        /// Post new post from form from newpost index
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public RedirectResult FormOne()
        {
            HttpPostedFileBase file = Request.Files["Image"];
            Post post = new Post
            {
                Content = Request.Form["content"],
                Author = new User { Username = Request.Form["author"], },
                CreationDate = DateTime.Now,
                Likes = 0,
                Views = 0,
                Title = Request.Form["title"],
                BackgroundImage = ConvertToByte(file)
            };

            _postService.Insert(post);
            return Redirect("/Home/Index");
        }


        /// <summary>
        /// Converts HttpPostedFileBase file to byte array
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public byte[] ConvertToByte(HttpPostedFileBase file)
        {
            byte[] imageByte = null;
            BinaryReader rdr = new BinaryReader(file.InputStream);
            imageByte = rdr.ReadBytes((int)file.ContentLength);
            return imageByte;
        }



    }
}