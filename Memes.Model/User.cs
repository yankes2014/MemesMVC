using System.Collections.Generic;

namespace Memes.Model
{
    /// <summary>
    /// Model of User
    /// </summary>
    public class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }
        #region Properties

        public int Id { get; set; }
        /// <summary>
        /// Username of User
        /// </summary>
        public string Username { get; set; }

        #endregion

        #region NavigationProperties
        /// <summary>
        /// Created Posts by User
        /// </summary>
        public ICollection<Post> Posts { get; set; }
        /// <summary>
        /// Created Comments by User
        /// </summary>
        public ICollection<Comment> Comments { get; set; }

        #endregion
    }
}
