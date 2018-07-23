using System;

namespace Memes.MVC.Models
{
    /// <summary>
    /// ViewModel of Post Model
    /// </summary>
    public class PostViewModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Title of PostViewModel
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Content of PostViewModel
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Author of PostViewModel
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// DateTime when PostViewModel was created
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Likes of PostViewModel
        /// </summary>
        public int Likes { get; set; }
        /// <summary>
        /// Views of PostViewModel
        /// </summary>
        public int Views { get; set; }
        /// <summary>
        /// Number of Comments of PostViewModel
        /// </summary>
        public int Comments { get; set; }
        /// <summary>
        /// BackgroundImage of PostViewModel
        /// </summary>
        public string BackgroundImgSrc { get; set; }
    }
}