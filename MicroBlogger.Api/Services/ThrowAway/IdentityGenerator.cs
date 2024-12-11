using System;

namespace MicroBlogger.Api.Services.ThrowAway;

public class IdentityGenerator : IIdentityGenerator
{
    private readonly Guid _state = Guid.NewGuid();
    public Guid State => _state;
}
