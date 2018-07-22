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
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public int Likes { get; set; }
        public int Views { get; set; }
        public byte[] BackgroundImage { get; set; }

        #endregion

        #region NavigationProperties

        virtual public User Author { get; set; }
        public ICollection<Comment> Comments { get; set; }

        #endregion
    }
}
