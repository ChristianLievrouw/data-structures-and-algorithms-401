using System;
namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void Insert(int value)
        {
            
            Node newNode = new Node(value);

            newNode.Next = Head;

            Head = newNode;
        }

        public bool Includes(int value)
        {
            Node current = Head;
            int input = value;

            while(current != null)
            {
                if (current.Value == input)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            Node current = Head;
            if(Head == null)
            {
                Head = newNode;
                return;
            }

            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddBefore(int value, int newValue)
        {
            Node newNode = new Node(newValue);
            Node current = Head;
            

            while (current.Next != null)
            {
                if(current.Next.Value == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
        }

        public void AddAfter(int value, int newValue)
        {
            Node newNode = new Node(newValue);
            Node current = Head;

            while (current.Next != null)
            {
                if(current.Value == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
        }

        public override string ToString()
        {
            Node current = Head;
            string result = "";

            while(current != null)
            {
                result += $"{{ {current.Value} }} -> ";
                current = current.Next;
            }
            return result + "NULL";
        }
    }
}
