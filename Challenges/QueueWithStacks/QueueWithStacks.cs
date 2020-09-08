using System;
using DataStructures.Stack;


namespace Challenges.QueueWithStacks
{
    public class QueueWithStacks<T> : Stack<T>
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        public void Enqueue(T value)
        {
            if(stack.IsEmpty() != true)
            {
                stack2.Push(stack.Pop());

            }
            stack.Push(4);

            while (stack2.IsEmpty() != true)
            {
                stack.Push(stack2.Pop());
            }
        }

        public int Dequeue()
        {
            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }

            int value = stack.Peek();
            stack.Pop();
            return value;
        }

        public class Node
        {

            public Node(int value)
            {
                Value = value;
            }

            // Value of this node
            public int Value { get; set; }

            // Pointer to the next node in the list
            public Node Next { get; set; }
        }
    }
}
    


