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

        //[Fact]
        //public void Breadth_first_test()
        //{
        //    BinaryTree tree = new BinaryTree();
        //    tree.Root = new BinaryTree.Node(1);
        //    tree.Root.Left = new BinaryTree.Node(2);
        //    tree.Root.Right = new BinaryTree.Node(3)
        //    {
        //        Left = new BinaryTree.Node(4),
        //        Right = new BinaryTree.Node(5),
        //    };

        //    var result = tree.BreadthFirst();
           
        //    Assert.Empty(result);
        //}
    }
}
