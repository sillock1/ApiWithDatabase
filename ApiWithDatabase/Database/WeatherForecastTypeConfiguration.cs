using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiWithDatabase.Database;

public class WeatherForecastTypeConfiguration : IEntityTypeConfiguration<WeatherForecast>
{
    public void Configure(EntityTypeBuilder<WeatherForecast> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasData(new WeatherForecast{Date = DateTime.Now, Id = Guid.NewGuid(), Summary = "First", TemperatureC = 20});
    }
}