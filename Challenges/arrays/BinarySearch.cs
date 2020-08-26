using System;
namespace Challenges.arrays
{
    public class BinarySearch
    {
        public static int Search(int[] array, int num)
        {
            int minNum = 0;
            int maxNum = array.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (num == array[mid])
                {
                    return mid;
                }
                else if (num < array[mid])
                {
                    maxNum = mid - 1;
                }
                else if (num > array[mid])
                {
                    minNum = mid + 1;
                }
            }
            return -1;
        }

    }
}
