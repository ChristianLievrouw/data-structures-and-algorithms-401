using System;
using DataStructures.Trees;

using Xunit;

namespace DataStructures.Tests.TreesTests
{
    public class TreeTests
    {
        [Fact]
        public void Add_Binary_Tree_can_add_multiple_nodes()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            // Act
            tree.Add(6);

            //Assert
            Assert.Equal(6, tree.Root.Value);
           
        }

        [Fact]
        public void FindFindMaxValue_returns_max_int()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(10);
            tree.Add(1);
            tree.Add(9);
            tree.Add(20);
            // Act
            int result = tree.FindMax(tree.Root);
            // Assert
            Assert.Equal(20, result);
        }
    }
}
