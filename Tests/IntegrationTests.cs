using Microsoft.AspNetCore.Hosting;
using Xunit;

namespace Session8.Tests
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;

        public IntegrationTests(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task Get_SomeData_ReturnsDataFromDb()
        {
            // Arrange
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/someData");

            // Act
            var response = await _httpClient.SendAsync(request);

            // Assert
            Assert.True(response.IsSuccessStatusCode);
            // Add more assertions as needed
        }

      
    }
}
