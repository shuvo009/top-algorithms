using System;

namespace TopAlgorithms
{
    /// <summary>
    /// The idea is to divide the array into two subsets – sorted sublist and unsorted sublist.
    /// Initially, the sorted sublist is empty and the unsorted sublist is the entire input list.
    /// The algorithm proceeds by finding the smallest (or largest, depending on sorting order) element in the unsorted sublist,
    /// swapping it with the leftmost unsorted element (putting it in sorted order),
    /// and moving the sublist boundaries one element to the right.
    /// </summary>
    public class SelectionSort
    {
        public void Perform()
        {
            Console.WriteLine("Selection Sort:");
            var unSortedArray1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var unSortedArray2 = new int[] { 1, 9, 3, 2, 6, 4, 5, 8, 7, 10 };

            var sortedArray1 = Sort(unSortedArray1, unSortedArray1.Length);
            var sortedArray2 = Sort(unSortedArray2, unSortedArray2.Length);

            Console.WriteLine(string.Join(",", sortedArray1));
            Console.WriteLine(string.Join(",", sortedArray2));
        }


        private int[] Sort(int[] array, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                // find the minimum element in the unsorted subArray[i..n-1] 
                // and swap it with arr[i]
                var minIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    // if arr[j] element is less, then it is the new minimum
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //Swap values
                var tempMinValue = array[minIndex];
                array[minIndex] = array[i];
                array[i] = tempMinValue;
            }

            return array;
        }
    }
}
