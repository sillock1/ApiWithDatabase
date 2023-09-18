using ApiWithDatabase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<WeatherContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WeatherDatabase"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
var dbContext = app.Services.GetRequiredService<WeatherContext>();
dbContext.Database.EnsureCreated();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();