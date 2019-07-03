using System;
using System.Collections.Generic;
using System.Text;

namespace TopAlgorithms
{
    /// <summary>
    /// Quick sort is a divide and conquer algorithm.
    /// Like all divide and conquer algorithms, it first divides a large array into two smaller sub-arrays and then recursively sort the sub-arrays.
    /// Basically, three steps are involved in whole process
    /// 1) Pivot selection: Pick an element, called a pivot, from the array (usually the leftmost or the rightmost element of the partition).
    /// 2) Partitioning: Reorder the array so that all elements with values less than the pivot come before the pivot, while all elements with values greater than the pivot come after it (equal values can go either way). After this partitioning,  the pivot is in its final position.
    /// 3) Recur: Recursively apply the above steps to the sub-array of elements with smaller values than pivot and separately to the sub-array of elements with greater values than pivot.
    /// </summary>
    public class QuickSort
    {

        public void Perform()
        {
            Console.WriteLine("Marge Sort:");
            var array1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var array2 = new int[] { 1, 9, 3, 2, 6, 4, 5, 8, 7, 10 };

            PerformQuickSort(array1, 0, array1.Length - 1);
            PerformQuickSort(array2, 0, array2.Length - 1);

            Console.WriteLine(string.Join(",", array1));
            Console.WriteLine(string.Join(",", array2));
        }

        private int Partition(int[] array, int start, int end)
        {
            var pivot = array[end]; // Pick rightmost element as pivot from the array

            // elements less than pivot will be pushed to the left of pIndex
            // elements more than pivot will be pushed to the right of pIndex
            // equal elements can go either way

            int pIndex = start;

            // each time we finds an element less than or equal to pivot, pIndex
            // is incremented and that element would be placed before the pivot.
            for (int i = start; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    Swap(array, i, pIndex);
                    pIndex++;
                }
            }
            Swap(array, pIndex, end);
            return pIndex;
        }

        private void Swap(int[] array, int fromIndex, int toIndex)
        {
            var temp = array[toIndex];
            array[toIndex] = array[fromIndex];
            array[fromIndex] = temp;
        }

        private void PerformQuickSort(int[] array, int start, int end)
        {
            if (start >= end)
                return;
            var pivot = Partition(array, start, end);

            // recur on sub-array containing elements that are less than pivot
            PerformQuickSort(array, start, pivot - 1);

            // recur on sub-array containing elements that are more than pivot
            PerformQuickSort(array, pivot + 1, end);
        }
    }
}
