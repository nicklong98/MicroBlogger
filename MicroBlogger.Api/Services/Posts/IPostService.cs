using System;

namespace MicroBlogger.Api.Services.Posts;

public interface IPostService
{
    Task<Guid> CreatePostAsync(string text, string userHandle, bool isPublished, CancellationToken cancellationToken);
}
