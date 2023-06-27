using Session8.Controllers;
using System;
using Xunit;

namespace Session8.Tests
{
    
    public class ApiTests
    {
        [Fact]
        public void Get_SomeData_ReturnsData()
        {
            // Arrange
            var controller = new SomeDataController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            // Add more assertions as needed
        }

        // Add more test cases as needed
    }
}

