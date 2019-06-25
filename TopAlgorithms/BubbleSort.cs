using System;

namespace TopAlgorithms
{
    public class BubbleSort
    {
        /// <summary>
        /// The bubble sort algorithm can be easily optimized by observing that the n-th pass
        /// finds the n-th largest element and puts it into its final place. So, the inner loop
        /// can avoid looking at the last n-1 items when running for the n-th time.
        /// Another optimization would be to stop the algorithm when the inner loop dod not do any swap.
        /// </summary>
        public void Perform()
        {
            Console.WriteLine("Bubble Sort:");
            var unSortedArray1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var unSortedArray2 = new int[] { 1, 9, 3, 2, 6, 4, 5, 8, 7, 10 };

            var sortedArray1 = Sort(unSortedArray1, unSortedArray1.Length);
            var sortedArray2 = Sort(unSortedArray2, unSortedArray2.Length);

            Console.WriteLine(string.Join(",", sortedArray1));
            Console.WriteLine(string.Join(",", sortedArray2));
        }

        private int[] Sort(int[] array, int length)
        {
            var passCount = length - 1; // (n - 1) pass
            for (var i = 0; i < passCount; i++)
            {
                var innerPassCount = passCount - i;
                // last k items are already sorted, so inner loop can avoid looking at the last k items
                for (var j = 0; j < innerPassCount; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                // the algorithm can be stopped if the inner loop did not do any swap
            }

            return array;
        }
    }
}
