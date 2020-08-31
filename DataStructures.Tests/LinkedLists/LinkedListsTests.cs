using System;
using DataStructures.LinkedLists;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class LinkedListsTests
    {
        [Fact]
        public void LinkedList_starts_empty()
        {
            //ACT
            LinkedList list = new LinkedList();

            //Assert
            Assert.Equal("NULL", list.ToString());
        }

        [Fact]
        public void Insert_adds_value_to_start()
        {
            //Arrange
            LinkedList list = new LinkedList();

            //Act
            list.Insert(1);

            //Assert
            Assert.Equal("{ 1 } -> NULL", list.ToString());

            //Act
            list.Insert(2);

            //Assert
            Assert.Equal("{ 2 } -> { 1 } -> NULL", list.ToString());
        }

        [Fact]
        public void Includes_finds_input_in_list()
        { 
            //Arrange
            LinkedList list = new LinkedList();

            //Act
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);

            //Assert
            bool expected = true;
            Assert.Equal(list.Includes(4), expected);
        }

        [Fact]
        public void Includes_finds_input_not_in_list()
        {
            //Arrange
            LinkedList list = new LinkedList();

            //Act
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);

            //Assert
            bool expected = false;
            Assert.Equal(list.Includes(7), expected);
        }

        [Fact]
        public void Append_adds_node_to_end_of_ll()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            //// Act
            list.Append(4);
            // Assert
            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> { 4 } -> NULL", list.ToString());
        }

        [Fact]
        public void Append_adds_node_to_empty_ll()
        {
            // Arrange
            LinkedList list = new LinkedList();
            //// Act
            list.Append(4);
            // Assert
            Assert.Equal("{ 4 } -> NULL", list.ToString());
        }

        [Fact]
        public void InsertBefore_inserts_before_specified_node()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            //Act
            list.AddBefore(2, 5);
            // Assert
            Assert.Equal("{ 1 } -> { 5 } -> { 2 } -> { 3 } -> NULL", list.ToString());
        }

        [Fact]
        public void InsertAfter_inserts_after_specified_node()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            //Act
            list.AddAfter(2, 5);
            // Assert
            Assert.Equal("{ 1 } -> { 2 } -> { 5 } -> { 3 } -> NULL", list.ToString());
        }
    }
}
