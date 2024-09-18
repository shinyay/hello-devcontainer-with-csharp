using Xunit;
using SampleApp.Models;

namespace SampleApp.Models.Tests
{
    public class ErrorViewModelTest
    {
        [Fact]
        public void ShowRequestId_ReturnsTrue_WhenRequestIdIsNotNullOrEmpty()
        {
            // Arrange
            var model = new ErrorViewModel { RequestId = "123" };

            // Act
            var result = model.ShowRequestId;

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ShowRequestId_ReturnsFalse_WhenRequestIdIsNull()
        {
            // Arrange
            var model = new ErrorViewModel { RequestId = null };

            // Act
            var result = model.ShowRequestId;

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ShowRequestId_ReturnsFalse_WhenRequestIdIsEmpty()
        {
            // Arrange
            var model = new ErrorViewModel { RequestId = string.Empty };

            // Act
            var result = model.ShowRequestId;

            // Assert
            Assert.False(result);
        }
    }
}
