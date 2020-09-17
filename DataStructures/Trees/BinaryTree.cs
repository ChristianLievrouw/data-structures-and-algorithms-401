using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Trees
{
    public class BinaryTree<T>
    {
        public Node Root { get; set; }

        public IEnumerable<T> PreOrder()
        {
            List<T> result = new List<T>();
            PreOrder(result, Root);
            return result;
        }
       
        private IEnumerable<T> PreOrder(List<T> result, Node root)
        {
            if (root == null)
                return result;
            result.Add(root.Value);
            PreOrder(result, root.Left);
            PreOrder(result, root.Right);
            return result;
        }

        public IEnumerable<T> InOrder()
        {
            List<T> result = new List<T>();
            InOrder(result, Root);
            return result;
        }

        private IEnumerable<T> InOrder(List<T> result, Node root)
        {
            if (root.Left != null)           
                InOrder(result, root.Left);
            result.Add(root.Value);

            if (root.Right != null)
                InOrder(result, root.Right);
            return result;
        }

        public IEnumerable<T> PostOrder()
        {
            List<T> result = new List<T>();
            PostOrder(result, Root);
            return result;
        }

        private IEnumerable<T> PostOrder(List<T> result, Node root)
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

        public IEnumerable<T> BreadthFirst()
        {
            var queue = new Queue<Node>();
            var queueResult = new Queue<Node>();

            queue.Enqueue(this.Root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                queueResult.Enqueue(current);
                if (current == null)
                    continue;
                queue.Enqueue(current.Left);
                queue.Enqueue(current.Right);
            }
            while (queue.Count > 0)
                yield return queueResult.Dequeue().Value;
        }

        public class Node
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; set; }

            public Node Left { get; set; }

            public Node Right { get; set; }
        }
    }
}
