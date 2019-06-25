using System;

namespace TopAlgorithms
{
    /// <summary>
    /// The idea is to divide the array into two subsets – sorted subset and unsorted subset.
    /// Initally sorted subset consists of only one first element at index 0.
    /// Then for each iteration, insertion sort removes next element from the unsorted subset,
    /// finds the location it belongs within the sorted subset, and inserts it there.
    /// It repeats until no input elements remain
    /// </summary>
    public class InsertionSort
    {
        public void Perform()
        {
            Console.WriteLine("Insertion Sort:");
            var unSortedArray1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var unSortedArray2 = new int[] { 1, 9, 3, 2, 6, 4, 5, 8, 7, 10 };

            var sortedArray1 = Sort(unSortedArray1, unSortedArray1.Length);
            var sortedArray2 = Sort(unSortedArray2, unSortedArray2.Length);

            Console.WriteLine(string.Join(",", sortedArray1));
            Console.WriteLine(string.Join(",", sortedArray2));
        }


        private int[] Sort(int[] array, int length)
        {
            // Start from second element (element at index 0 is already sorted)
            for (int i = 1; i < length; i++)
            {
                var value = array[i];
                var j = i;

                // Find the index j within the sorted subset arr[0..i-1]
                // where element arr[i] belongs
                while (j > 0 && array[j - 1] > value)
                {
                    array[j] = array[j - 1];
                    j--;
                }

                // Note that subArray arr[j..i-1] is shifted to
                // the right by one position i.e. arr[j+1..i]
                array[j] = value;
            }

            return array;
        }
    }
}
