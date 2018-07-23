using System;

namespace Memes.Model
{
    /// <summary>
    /// Model of Comment
    /// </summary>
    public class Comment
    {

        #region Properties

        public int Id { get; set; }
        /// <summary>
        /// Content of Comment
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Date when Comment was created
        /// </summary>
        public DateTime CreationDate { get; set; }

        #endregion

        #region NavigationProperties
        /// <summary>
        /// Author of Comment
        /// </summary>
        public User Author { get; set; }
        /// <summary>
        /// Post of Comment
        /// </summary>
        public Post Post { get; set; }

        #endregion
    }
}
