
using API.Services;
using Infrastructure.Extensions;
using Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>(); // Register the WeatherForecastService as a service, usage of dependency injection.

// builder.Configuration.GetConnectionString("DefaultConnection"); // Get the connection string from appsettings.json
builder.Services.AddInfrastructure(builder.Configuration); // Call the extension method to add infrastructure services

var app = builder.Build();

var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<IDataSeeder>(); // Seed the database with initial data
await seeder.SeedAsync();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
