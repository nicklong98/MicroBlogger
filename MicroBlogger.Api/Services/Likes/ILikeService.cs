namespace MicroBlogger.Api.Services.Likes;

public interface ILikeService
{
    Task LikePostAsync(Guid postId, string userHandle, CancellationToken cancellationToken);
    Task DeleteLikeAsync(Guid postId, string userHandle, CancellationToken cancellationToken);
}
