using ApiWithDatabase.Database;
using Microsoft.EntityFrameworkCore;

namespace ApiWithDatabase;

public class WeatherContext : DbContext
{
    public WeatherContext(DbContextOptions<WeatherContext> options) : base(options){}
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WeatherForecastTypeConfiguration());
    }
}