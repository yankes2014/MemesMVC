using System;
using System.Collections.Generic;

namespace Memes.Model
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }
        #region Properties

        public int Id { get; set; }
        /// <summary>
        /// Title of Post
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Content of Post
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Time when post was created
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Number of Likes of Post
        /// </summary>
        public int Likes { get; set; }
        /// <summary>
        /// Number of Views of Post
        /// </summary>
        public int Views { get; set; }
        /// <summary>
        /// BackgroundImage of Post
        /// </summary>
        public byte[] BackgroundImage { get; set; }

        #endregion

        #region NavigationProperties
        /// <summary>
        /// Author of Post
        /// </summary>
        virtual public User Author { get; set; }
        /// <summary>
        /// Comments of Post
        /// </summary>
        public ICollection<Comment> Comments { get; set; }

        #endregion
    }
}
