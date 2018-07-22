using System;

namespace Memes.MVC.Models
{
    public class CommentViewModel
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}