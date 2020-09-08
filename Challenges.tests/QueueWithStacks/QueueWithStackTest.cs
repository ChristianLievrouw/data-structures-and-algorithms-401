using System;
using Challenges.QueueWithStacks;
using DataStructures.Stack;
using Xunit;

namespace Challenges.tests.QueueWithStacks
{
    public class QueueWithStackTest
    {
        [Fact]
        public void IsEmpty_returns_true_if_stack_is_empty()
        {
            // Arrange 
            Stack<int> stack = new Stack<int>();

            // Act
            bool result = stack.IsEmpty();

            // Assert
            Assert.True(result);

        }
        //[Fact]
        //public void Dequeue_a_stack()
        //{
        //    Stack<int> stack = new Stack<int>();

        //    stack.Push(3);
        //    stack.Push(2);
        //    stack.Push(1);

        //    Stack<int> stack2 = new Stack<int>();

        //    Assert.Equal(3, stack2.Peek());
        //}

        //[Fact]
        //public void Enqueue_a_stack()
        //{
        //    Stack<int> stack = new Stack<int>();

        //    stack.Push(3);
        //    stack.Push(2);
        //    stack.Push(1);
        //}
    }
}
