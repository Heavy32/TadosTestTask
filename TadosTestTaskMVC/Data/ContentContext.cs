using Microsoft.EntityFrameworkCore;
using TadosTestTask.Models.Contents;

namespace TadosTestTask
{
    public class ContentContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<Photo> Photos { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UsersRating> UsersRatings { get; set; }

        public ContentContext(DbContextOptions<ContentContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersRating>()
                .HasKey(ur => new { ur.UserId, ur.ContentId });

            modelBuilder.Entity<User>()
                .HasMany(u => u.UsersRatings)
                .WithOne(ur => ur.User)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
