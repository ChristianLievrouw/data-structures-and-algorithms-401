using System.Collections.Generic;
using DataStructures.HashTable;
using DataStructures.Trees;
using Xunit;

namespace DataStructures.Tests.HashTests
{
    public class IntersectionTests
    {
        [Fact]
        public void Bianary_tree_repeat()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            tree1.Root = 1;
            tree1.Root.Left = 2;
            tree1.Root.Right = 3;

            BinaryTree<int> tree2 = new BinaryTree<int>();
            tree2.Root = 1;
            tree2.Root.Left = 2;
            tree2.Root.Right = 4;

            // Make sure duplicate in tree2 does not show up
            tree2.Root.Right.Right = 4;

            List<int> value = Intersection.TreeIntersection(tree1, tree2);
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(2);
            Assert.Equal(expected, value);
        }

        [Fact]
        public void Binary_tree_repeat_again()
        {
            var tree1 = new BinaryTree<int>();
            tree1.Root = 4;

            var tree2 = new BinaryTree<int>();

            var value = Intersection.TreeIntersection(tree1, tree2);

            var expected = new List<int>(); // No duplicates!
            Assert.Equal(expected, value);
        }
    }
}