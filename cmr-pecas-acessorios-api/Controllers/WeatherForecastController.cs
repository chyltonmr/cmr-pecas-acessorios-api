using Microsoft.AspNetCore.Mvc;
using System.Data;
using Dapper;
using MySqlConnector;

namespace cmr_pecas_acessorios_api.Controllers;

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

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {

     

        string connectionString = "Server=localhost;Port=3306;Database=world;User Id=root;Password=080205;";
        using IDbConnection db = new MySqlConnection(connectionString);

        var clientes = db.Query<object>("SELECT * FROM city");

        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente}, Nome: {cliente}, Email: {cliente}");
        }


        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
