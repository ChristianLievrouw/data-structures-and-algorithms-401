using System.Collections.Generic;
using DataStructures.Trees;

namespace DataStructures.HashTable
{
    public class Intersection<T>
    {
        public static List<int> TreeIntersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            var hashTable = new Dictionary<int, int>();

            List<int> resultList = new List<int>();

            var list = tree1.PreOrder();
            foreach (int num in list)
            {
                hashTable.Add(num, num);
            }

            var list2 = tree2.PreOrder();
            foreach (int num in list2)
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