using MicroBlogger.Api.Dtos;

namespace MicroBlogger.Api.Services.Posts;

public interface IPostService
{
    Task<PostDto?> CreatePostAsync(string text, string userHandle, bool isPublished, CancellationToken cancellationToken);
    Task<List<PostDto>> GetPostsAsync(CancellationToken cancellationToken);
    Task<List<PostDto>> GetPostsForUserAsync(string userHandle, CancellationToken cancellationToken);
    Task<PostDto?> GetPostByIdAsync(Guid postId, CancellationToken cancellationToken);
    Task<PostDto?> UpdatePostAsync(Guid postId, string text, bool isPublished, CancellationToken cancellationToken);
    Task DeletePostAsync(Guid postId, CancellationToken cancellationToken);
}
