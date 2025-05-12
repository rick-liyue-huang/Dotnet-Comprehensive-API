using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
    {
        _logger = logger;
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("Getting weather forecasts");
        return _weatherForecastService.Get();
    }

    [HttpGet]
    [Route("{take}/example")]
    public IEnumerable<WeatherForecast> Get([FromQuery]int max, [FromRoute]int take)
    {
        _logger.LogInformation("Getting weather forecasts with take");
        return _weatherForecastService.Get();
    }

    [HttpGet("currentDay")]
    public WeatherForecast GetCurrentDay()
    {
        _logger.LogInformation("Getting current day weather forecast");

        Response.StatusCode = 400;
        return _weatherForecastService.Get().First();
    }

    
    
    [HttpPost]
    public string Hello([FromBody] string name)
    {
        return $"Hello {name}";
    }
}
