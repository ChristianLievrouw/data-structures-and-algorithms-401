using System;
namespace Challenges.Sorts
{
    public class MSort
    {
        public int[] MergeSort(int[] arr)
        {
            int[] leftArr;
            int[] rightArr;
            int[] result = new int[arr.Length - 1];

            if (arr.Length <= 1)
                return arr;

            int mid = arr.Length / 2;

            leftArr = new int[mid];

            if (arr.Length % 2 == 0)
                rightArr = new int[mid];
            else
                rightArr = new int[mid + 1];

            for (int i = 0; i < mid; i++)
                leftArr[i] = arr[i];

            int x = 0;

            for (int i = mid; i < arr.Length; i++)
            {
                rightArr[x] = arr[i];
                x++;
            }

            leftArr = MergeSort(leftArr);
            rightArr = MergeSort(rightArr);
            result = Merge(leftArr, rightArr);
            return result;

        }

        public int[] Merge(int[] leftArr, int[] rightArr)
        {
            int resultLength = leftArr.Length + rightArr.Length;
            int[] result = new int[resultLength];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < leftArr.Length || j < rightArr.Length)
            {
                if (i < leftArr.Length && j < rightArr.Length)
                {
                    if (leftArr[k] <= rightArr[j])
                    {
                        result[k] = leftArr[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        result[k] = rightArr[j];
                        j++;
                        k++;
                    }
                }
                else if(i == leftArr.Length)
                {
                    result[k] = leftArr[i];
                    i++;
                    k++;
                }
                else if(j == rightArr.Length)
                {
                    result[k] = rightArr[j];
                    j++;
                    k++;
                }
            }
            return result;
        }
    }
}

//ALGORITHM Mergesort(arr)
//    DECLARE n<-- arr.length

//    if n > 1
//      DECLARE mid <-- n/2
//      DECLARE left <-- arr[0...mid]
//      DECLARE right<-- arr[mid...n]
//      // sort the left side
//      Mergesort(left)
//      // sort the right side
//      Mergesort(right)
//      // merge the sorted left and right sides together
//      Merge(left, right, arr)




//ALGORITHM Merge(left, right, arr)
//    DECLARE i<-- 0
//    DECLARE j <-- 0
//    DECLARE k <-- 0

//    while i < left.length && j < right.length
//        if left[i] <= right[j]
//            arr[k] <-- left[i]
//            i <-- i + 1
//        else
//            arr[k] <-- right[j]
//            j <-- j + 1


//        k<-- k + 1

//    if i = left.length
//       set remaining entries in arr to remaining values in right
//    else
//       set remaining entries in arr to remaining values in left