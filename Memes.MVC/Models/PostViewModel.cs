using System;

namespace Memes.MVC.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime CreationDate { get; set; }
        public int Likes { get; set; }
        public int Views { get; set; }
        public int Comments { get; set; }
        public string BackgroundImgSrc { get; set; }
    }
}