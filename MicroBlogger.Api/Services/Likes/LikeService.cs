
namespace MicroBlogger.Api.Services.Likes;

public class LikeService : ILikeService
{
    public Task DeleteLikeAsync(Guid postId, string userHandle, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task LikePostAsync(Guid postId, string userHandle, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
