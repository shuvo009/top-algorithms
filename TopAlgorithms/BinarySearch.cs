using System;
using System.Collections.Generic;
using System.Text;

namespace TopAlgorithms
{
    /// <summary>
    /// The idea is to use Binary Search. Binary Search is a divide and conquer algorithm.
    /// Like all divide and conquer algorithms, Binary Search first divides a large array into two smaller sub-arrays and then recursively operate the sub-arrays.
    /// But instead of operating on both sub-arrays, it discards one sub-array and continue on the second sub-array.
    /// This decision of discarding one sub-array is made in just one comparison.
    /// </summary>

    public class BinarySearch
    {
        public void Perform()
        {
            Console.WriteLine("Binary Search:");
            var unSortedArray1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var unSortedArray2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var targetIndex1 = Search(unSortedArray1, 0, unSortedArray1.Length - 1, 3);
            var targetIndex2 = Search(unSortedArray2, 0, unSortedArray2.Length - 1, 11);

            Console.WriteLine($"3 is found at {targetIndex1}");
            Console.WriteLine($"11 is found at {targetIndex2}");
        }


        private int Search(int[] array, int start, int end, int target)
        {
            if (start > end)
                return -1;

            var middle = (start + end) / 2;

            //target value is found
            if (target == array[middle])
                return middle;

            if (target < array[middle])
            {
                //discard all elements in the right search space
                return Search(array, start, middle, target);
            }
            else
            {
                //discard all elements in the left search space
                return Search(array, middle + 1, end, target);
            }
        }
    }
}
