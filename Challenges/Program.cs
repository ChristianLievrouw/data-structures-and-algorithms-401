﻿using System;
using Challenges.Arrays;
namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToReverse = new[] { 1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine(String.Join(",", Reverse.ReverseArray(arrayToReverse)));
        }
    }
}