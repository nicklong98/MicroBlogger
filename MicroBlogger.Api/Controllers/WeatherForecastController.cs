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

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
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
    public string HelloWorld(string name)
    {
        return $"Hello {name}";
    }
}
