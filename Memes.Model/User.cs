using System.Collections.Generic;

namespace Memes.Model
{
    public class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }
        #region Properties

        public int Id { get; set; }
        public string Username { get; set; }

        #endregion

        #region NavigationProperties

        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }

        #endregion
    }
}
