using System;
using Challenges.arrays;
using Xunit;

namespace Challenges.tests.arrays
{
    public class BinaryTests
    {
        [Theory]
        [InlineData(new[] {1, 2, 3, 4, 5, 6}, 2, 1)]
        public void BinarySearch_search_for_input_num_in_array(int[] testArray, int testNum, int expected)
        {
            // Arrange
            // Act
            int result = BinarySearch.Search(testArray, testNum);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
