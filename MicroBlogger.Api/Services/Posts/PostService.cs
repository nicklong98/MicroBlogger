using MicroBlogger.Api.Data.Context;
using MicroBlogger.Api.Dtos;

namespace MicroBlogger.Api.Services.Posts;

public class PostService(MicroBloggerContext context) : IPostService
{
    public Task<PostDto?> CreatePostAsync(string text, string userHandle, bool isPublished, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeletePostAsync(Guid postId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<PostDto?> GetPostByIdAsync(Guid postId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<List<PostDto>> GetPostsAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<List<PostDto>> GetPostsForUserAsync(string userHandle, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<PostDto?> UpdatePostAsync(Guid postId, string text, bool isPublished, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
