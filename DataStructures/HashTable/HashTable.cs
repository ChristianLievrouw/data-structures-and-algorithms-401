﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.HT
{
    public class HT<TValue>
    {
        LinkedList<TValue>[] HashTable = new LinkedList<TValue>[3];

        public static int GetHash(string key)
        {
            int[] keyNumArr = new int[key.Length];

            for (int i = 0; i < key.Length; i++)
                keyNumArr[i] = (int)key[i];

            int sum = 0;
            foreach(int num in keyNumArr)
            {
                sum += num;
            }

            int primeNum = 3;

            int Hashnum = sum * primeNum;

            return Hashnum;
        }

        public void Add(string key, TValue value)
        {
            int bucketNum = GetHash(key) % HashTable.Length;
            var bucket = HashTable[bucketNum];

            LinkedListNode<TValue> newNode = new LinkedListNode<TValue>(value);
            bucket.AddFirst(newNode);
        }

        public TValue HashFind(string key)
        {
            int hashNumber = GetHash(key);
            int bucketNumber = hashNumber % HashTable.Length;

            if (HashTable[bucketNumber] == null)
                throw new KeyNotFoundException();
            else
                return HashTable[bucketNumber].First();
        }
    }
}

