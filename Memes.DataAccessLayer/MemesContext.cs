using Memes.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Memes.DataAccessLayer
{
    public class MemesContext : DbContext
    {
        public MemesContext() : base("Blog")
        {

        }
        /// <summary>
        /// Set of Posts
        /// </summary>
        public DbSet<Post> Posts { get; set; }
        /// <summary>
        /// Set of Users
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Set of Comments
        /// </summary>
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
