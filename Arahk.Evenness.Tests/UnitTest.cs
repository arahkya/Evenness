using System.Net;
using Arahk.Evenness.Lib;
using Arahk.Evenness.Lib.Domain.Entities;
using Arahk.Evenness.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Arahk.Evenness.Tests;

public class UnitTest(WebApplicationFactory<Program> webApplicationFactory) : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory = webApplicationFactory;

    [Fact]
    public async Task TestGetWeatherForecast()
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync("project");

        // Assert
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task CreateProjectTest()
    {
        // Arrange
        var client = _factory.CreateClient();
        var project = new CreateProjectViewModel
        {
            Name = "Test Project",
            Description = "Test Description",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(7)
        };

        // Act
        var response = await client.PostAsJsonAsync("project/create", project);

        // Assert
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
    }
}
