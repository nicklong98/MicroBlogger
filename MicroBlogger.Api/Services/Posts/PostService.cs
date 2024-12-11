using System;
using MicroBlogger.Api.Data.Context;
using MicroBlogger.Api.Data.Entities;

namespace MicroBlogger.Api.Services.Posts;

public class PostService(MicroBloggerContext context) : IPostService
{
    public async Task<Guid> CreatePostAsync(string text, string userHandle, bool isPublished, CancellationToken cancellationToken)
    {
        var post = new Post
        {
            Text = text,
            UserHandle = userHandle,
            IsPublished = isPublished
        };
        await context.Posts.AddAsync(post, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

        return post.Id;
    }
}
