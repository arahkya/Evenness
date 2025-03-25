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
        var response = await client.GetAsync("weatherforecast");

        // Assert
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync();

        Assert.Contains("temperatureC", responseString);
    }
}
