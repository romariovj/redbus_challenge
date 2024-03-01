using FluentAssertions;

namespace App.Test
{
    public class DeliveryBikeTest
    {
        [Fact]
        public void Count_WithGroupWeight10_Return4Bikes()
        {
            // Arrange
            DeliveryBike deliveryBike = new DeliveryBike();
            int[] packagesWeights = { 5, 3, 2, 5, 6, 1, 4, 7, 9 };
            int groupWeight = 10;

            // Act
            int totalBikes = deliveryBike.Count(packagesWeights, groupWeight);

            // Assert
            var okResult = totalBikes.Should().Be(4);

        }
    }
}