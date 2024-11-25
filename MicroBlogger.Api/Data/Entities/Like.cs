namespace MicroBlogger.Api.Data.Entities;

public class Like
{
    public Guid PostId { get; set; }
    public string UserHandle { get; set; } = string.Empty;

    public Post? Post { get; set; }
}
