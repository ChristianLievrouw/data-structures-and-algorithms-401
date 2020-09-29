using System;
using Challenges.Sorts;
using Xunit;

namespace Challenges.tests.SortTests
{
    public class InsertionTest
    {
        [Fact]
        public void Insertion_array_in_order()
        {
            // Arrange
            int[] newArray = new[] { 23, 75, 101, 4 };

            // Act
            int[] result = InsertionSort.Insertion(newArray);

            //Assert
            Assert.Equal(new int[] { 4, 23, 75, 101 }, result);
        }
    }
}

