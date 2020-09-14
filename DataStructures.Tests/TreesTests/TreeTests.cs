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
    }
}
