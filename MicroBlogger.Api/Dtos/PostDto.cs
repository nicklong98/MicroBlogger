namespace MicroBlogger.Api.Dtos;

public record PostDto(Guid Id,
    string Text,
    string UserHandle,
    bool IsPublished,
    DateTime CreatedAt,
    int LikeCount);
