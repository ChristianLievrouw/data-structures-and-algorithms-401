using System;
using Challenges.Sorts;
using Challenges.Sorts.Assets;
using Xunit;

namespace Challenges.tests.SortTests
{
    public class QuickSortTest
    {
        [Fact]
        public void Quick_sort_array()
        {
            // Arrange
            int[] newArray = new[] { 23, 75, 4, 45, 76 };

            // Act
            int[] result = Quick.quickSort(newArray);

            //Assert
            Assert.Equal(new int[] { 4, 23, 45, 75, 76 }, result);
        }
    }
}