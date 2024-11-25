namespace MicroBlogger.Api.Data.Entities;

public class Post
{
    public Guid Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public string UserHandle { get; set; } = string.Empty;
    public bool IsPublished { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);
    public DateTime? LastEditedAt { get; set; }

    public ICollection<Like> Likes { get; set; } = [];
}
