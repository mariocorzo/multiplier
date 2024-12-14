using McorzoMultiplyNumbers;

namespace McorzoMultiplyNumbers.Tests
{

    public class MathHelperTests
    {
        [Fact]
        public void Multiply_ShouldReturnCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = MathHelper.Multiply(a, b);

            // Assert
            Assert.Equal(15, result);
        }
    }
}
