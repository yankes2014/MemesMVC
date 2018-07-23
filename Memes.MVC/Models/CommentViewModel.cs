using System;

namespace Memes.MVC.Models
{
    /// <summary>
    /// ViewModel of Comment Model
    /// </summary>
    public class CommentViewModel
    {
        /// <summary>
        /// Author of Comment
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Content of Comment
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// DateTime when Comment was created
        /// </summary>
        public DateTime CreationDate { get; set; }
    }
}