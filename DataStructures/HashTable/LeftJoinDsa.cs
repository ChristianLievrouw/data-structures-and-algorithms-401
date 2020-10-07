using System;
using System.Collections.Generic;

namespace DataStructures.HashTable
{
    public class LeftJoinDsa
    {
        public static List<string[]> LeftJoinList(Dictionary<string, string> hash1, Dictionary<string, string> hash2)
        {
            ICollection<string> key1 = hash1.Keys;

            List<string[]> resultList = new List<string[]>();

            foreach (var key in key1)
            {
                string[] arr = new string[3];
                arr[0] = key;
                hash1.TryGetValue(key, out string y);
                arr[1] = y;
                hash2.TryGetValue(key, out string x);
                arr[2] = x;
                resultList.Add(arr);
            }
            return resultList;
        }
    }
}
