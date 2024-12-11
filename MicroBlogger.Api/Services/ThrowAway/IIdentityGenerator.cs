using System;

namespace MicroBlogger.Api.Services.ThrowAway;

public interface IIdentityGenerator
{
    Guid State { get; }
}
