using Arahk.Evenness.Lib.Application.Interfaces;
using Arahk.Evenness.Lib.Infrastructure;
using Arahk.Evenness.Lib.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddTransient<IProjectRepository, ProjectRepository>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<EvennessDbContext>(options =>
{
    options.UseInMemoryDatabase("EvennessDb");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

public partial class Program { }