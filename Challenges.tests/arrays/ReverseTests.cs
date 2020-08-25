using System;
using Challenges.Arrays;
using Xunit;

namespace Challenges.tests.arrays
{
    public class ReverseTests
    {
        [Fact]
        public void ReverseArray_reverses_an_empty_array()
        {
            // Arrange
            int[] arrayToReverse = new[] { 1, 2, 3 };

            // Act
            int[] result = Reverse.ReverseArray(arrayToReverse);

            //Assert
            Assert.Equal(new int[] { 3, 2, 1 }, result);
        }
    }
}
