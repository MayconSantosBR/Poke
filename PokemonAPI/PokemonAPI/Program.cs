using Microsoft.EntityFrameworkCore;
using PokemonAPI.Context;
using PokemonAPI.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging(logger =>
{
    logger.AddConsole();
    logger.AddConsole();
    logger.SetMinimumLevel(LogLevel.Information);
});

builder.Services.AddDbContext<MainContext>(options =>
{
    options.UseNpgsql(EnviromentConfig.Hosts.Database);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
