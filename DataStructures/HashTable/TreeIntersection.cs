using System.Collections.Generic;
using DataStructures.Trees;

namespace DataStructures.HashTable
{
    public class Intersection
    {
        public static List<T> TreeIntersection<T>(BinaryTree<T> tree1, BinaryTree<T> tree2)
        {
            var hashTable = new Dictionary<T, T>();

            List<T> resultList = new List<T>();

            var list = tree1.PreOrder();
            foreach (T num in list)
            {
                hashTable.Add(num, num);
            }

            var list2 = tree2.PreOrder();
            foreach (T num in list2)
            {
                if (hashTable.ContainsKey(num))
                {
                    resultList.Add(num);
                }
            }
            return resultList;
        }
    }
}