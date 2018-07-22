using System;

namespace Memes.Model
{
    public class Comment
    {

        #region Properties

        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }

        #endregion

        #region NavigationProperties

        public User Author { get; set; }
        public Post Post { get; set; }

        #endregion
    }
}
