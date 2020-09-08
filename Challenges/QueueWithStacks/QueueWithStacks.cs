using System;
using DataStructures.Stack;


namespace Challenges.QueueWithStacks
{
    public class QueueWithStacks<T>
    {
        Stack<T> stack = new Stack<T>();
        Stack<T> stack2 = new Stack<T>();

        public void Enqueue(T value)
        {
            if(stack.IsEmpty() != true)
            {
                stack2.Push(stack.Pop());

            }
            stack.Push(value);

            while (stack2.IsEmpty() != true)
            {
                stack.Push(stack2.Pop());
            }
        }

        public T Dequeue()
        {
            if (stack.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            T value = stack.Pop();
            return value;
        }

        public bool IsEmpty()
        {
            if(stack.IsEmpty() || stack2.IsEmpty())
                return true;
            else
                return false;
        }

        public T Peek()
        {
            return stack.Peek();
        }
    }
}
    


