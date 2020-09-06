using System;
using System.Collections.Generic;

namespace DataStructures.Stack
{


    public class Stack<T>
    {
        public class Node
        {

            public Node(T value)
            {
                Value = value;
            }

            // Value of this node
            public T Value { get; set; }

            // Pointer to the next node in the list
            public Node Next { get; set; }
        }

        public Node Top { get; set; }

        public void Push(T value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        public T Pop()
        {
            if (Top == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Node temp = Top;
                Top = temp.Next;
                temp.Next = null;
                return temp.Value;
            }
        }

        public T Peek()
        {
            if (Top == null)
            {
                throw new InvalidOperationException();
            }
            else
                return Top.Value;
        }

        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }

            else
                return false;
        }
    }
    public class Queue<T>
    {
        public class Node
        {

            public Node(T value)
            {
                Value = value;
            }

            // Value of this node
            public T Value { get; set; }

            // Pointer to the next node in the list
            public Node Next { get; set; }

        }

        public Node Front { get; set; }

        public Node Rear { get; set; }

        public void Enqueue(T value)
        {
            Node node = new Node(value);
            if (Front == null)
            {
                node.Next = node;
                Front = node;
            }
            else
            {
                node.Next = node;
                Rear = node;
            }
        }

        public T Dequeue()
        {
            if (Front == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;

                return temp.Value;
            }

        }

        public T QPeek()
        {
            if (Front == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return Front.Value;
            }
        }

        public bool QIsEmpty()
        {
            if (Front == null)
            {
                return true;
            }

            else
                return false;
        }
    }
}