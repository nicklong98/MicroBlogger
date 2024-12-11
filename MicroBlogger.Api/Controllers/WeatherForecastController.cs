using MicroBlogger.Api.Services.Posts;
using MicroBlogger.Api.Services.ThrowAway;
using Microsoft.AspNetCore.Mvc;

namespace MicroBlogger.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IIdentityGenerator _identityGenerator;
    private readonly IPostService _postService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IIdentityGenerator identityGenerator,
        IPostService postService)
    {
        _logger = logger;
        _identityGenerator = identityGenerator;
        _postService = postService;
    }

    [HttpGet]
    public WeatherForecast GetWeatherForecast()
    {
        return new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.UtcNow),
            Summary = "Hot",
            TemperatureC = 40,
        };
    }

    [HttpGet("hello")]
    public async Task<string> HelloWorld(string name)
    {
        var postId = await _postService.CreatePostAsync("Hello world", name, true, HttpContext.RequestAborted);
        return $"Your post id is {postId}";
    }
}
