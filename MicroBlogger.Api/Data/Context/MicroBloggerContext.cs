using MicroBlogger.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MicroBlogger.Api.Data.Context;

public class MicroBloggerContext(DbContextOptions<MicroBloggerContext> options) : DbContext(options)
{
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Like> Likes => Set<Like>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Like>().HasKey(like => new { like.PostId, like.UserHandle });
        modelBuilder.Entity<Post>().Property(post => post.Text).HasMaxLength(240);
    }
}
