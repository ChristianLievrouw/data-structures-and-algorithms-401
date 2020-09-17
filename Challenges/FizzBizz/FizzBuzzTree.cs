using System;
using System.Collections.Generic;
using DataStructures.Trees;

namespace Challenges.FizzBizz
{
    public class FizzBuzzTree<T> 
    {
       public IEnumerable<string> FizzBuzz(BinaryTree<int> tree)
        {
            var treeList = tree.InOrder();

            foreach (int num in treeList)
            {
                if (num % 3 == 0 && num % 5 == 0)
                    yield return "FizzBuzz";
                else if (num % 3 == 0)
                    yield return "Fizz";
                else if (num % 5 == 0)
                    yield return "Buzz";
                else
                    yield return num.ToString();
            }
        }
    }
}