using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Trees
{
    public class BinaryTree 
    {
        public Node Root { get; set; }

        public IEnumerable<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreOrder(result, Root);
            return result;
        }
       
        private IEnumerable<int> PreOrder(List<int> result, Node root)
        {
            if (root == null)
                return result;
            result.Add(root.Value);
            PreOrder(result, root.Left);
            PreOrder(result, root.Right);
            return result;
        }

        public IEnumerable<int> InOrder()
        {
            List<int> result = new List<int>();
            InOrder(result, Root);
            return result;
        }

        private IEnumerable<int> InOrder(List<int> result, Node root)
        {
            if (root.Left != null)           
                InOrder(result, root.Left);
            result.Add(root.Value);

            if (root.Right != null)
                InOrder(result, root.Right);
            return result;
        }

        public IEnumerable<int> PostOrder()
        {
            List<int> result = new List<int>();
            PostOrder(result, Root);
            return result;
        }

        private IEnumerable<int> PostOrder(List<int> result, Node root)
        {
            if(root.Left != null)
            {
                PostOrder(result, root.Left);
            }
            if(root.Right != null)
            {
                PostOrder(result, root.Right);
                result.Add(root.Value);
            }
            return result;
        }

        public IEnumerable<int> BreadthFirst()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(this.Root);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                yield return current.Value;
                if (current == null)
                    continue;
                queue.Enqueue(current.Left);
                queue.Enqueue(current.Right);
            }
        }

        public class Node
        {
            public Node(int value)
            {
                Value = value;
            }

            public int Value { get; set; }

            public Node Left { get; set; }

            public Node Right { get; set; }
        }
    }
}
