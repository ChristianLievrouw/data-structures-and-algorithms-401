using System;
using System.Collections.Generic;
using DataStructures.Trees;

namespace DataStructures.HashTable
{
    public class Intersection<T>
    {
        public Dictionary<int, int> hashTable = new Dictionary<int, int>();

        public List<int> TreeIntersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            List<int> resultList = new List<int>();

            var list = tree1.BreadthFirst();
            foreach(int num in list)
            {
                hashTable.Add(num, num);
            }

            var list2 = tree2.BreadthFirst();
            foreach(int num in list2)
            {
                if(hashTable.ContainsKey(num))
                {
                    resultList.Add(num);
                }
                else
                {
                    hashTable.Add(num, num);
                }
            }
            return resultList;
        }
    }
}
