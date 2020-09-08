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
            QueueWithStacks<int> queue = new QueueWithStacks<int>();

            // Act
            bool result = queue.IsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEmpty_returns_false_if_stack_is_not_empty()
        {
            // Arrange 
            QueueWithStacks<int> queue = new QueueWithStacks<int>();

            queue.Enqueue(1);

            // Act
            bool result = queue.IsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Peek_bottom_of_queue()
        {
            // Arrange 
            QueueWithStacks<int> queue = new QueueWithStacks<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // Assert
            Assert.Equal(1, queue.Peek());
        }

        [Fact]
        public void Dequeue_from_stack()
        {
            QueueWithStacks<int> queue = new QueueWithStacks<int>();

            queue.Enqueue(1);

            int result = queue.Dequeue();

            Assert.Equal(1, result);
        }

        [Fact]
        public void Dequeue_from_empty_stack()
        {
            QueueWithStacks<int> queue = new QueueWithStacks<int>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                return queue.Dequeue();
            });
        }
    }
}
