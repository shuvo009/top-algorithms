using System;

namespace TopAlgorithms
{
    /// <summary>
    /// Merge sort is a divide and conquer algorithm. Like all divide and conquer algorithms,
    /// merge sort divides a large array into two smaller subArrays and then recursively sort the subArrays.
    /// Basically, there are two steps are involved in whole process
    /// 1) Divide the unsorted array into n subArrays, each of size 1 (an array of size 1 is considered sorted)
    /// 2) Repeatedly merge subArrays to produce new sorted subArrays until only 1 subArrays is left which would be our sorted array.
    /// </summary>
    public class MargeSort
    {
        public void Perform()
        {
            Console.WriteLine("Marge Sort:");
            var array1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var array2 = new int[] { 1, 9, 3, 2, 6, 4, 5, 8, 7, 10 };

            PerformMargeSort(array1, 0, array1.Length - 1);
            PerformMargeSort(array2, 0, array2.Length - 1);

            Console.WriteLine(string.Join(",", array1));
            Console.WriteLine(string.Join(",", array2));
        }



        private void PerformMargeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                var middle = (left + right) / 2;
                PerformMargeSort(array, left, middle);
                PerformMargeSort(array, middle + 1, right);

                PerformMarge(array, left, middle, right);
            }
        }

        private void PerformMarge(int[] array, int left, int middle, int right)
        {
            var tempArray = new int[array.Length];
            var i = left;
            var k = left;
            var j = middle + 1;

            while (i <= middle && j <= right)
            {
                if (array[i] <= array[j])
                {
                    tempArray[k] = array[i];
                    k++;
                    i++;
                }
                else
                {
                    tempArray[k] = array[j];
                    k++;
                    j++;
                }
            }

            while (i <= middle)
            {
                tempArray[k] = array[i];
                k++;
                i++;
            }

            while (j <= right)
            {
                tempArray[k] = array[j];
                k++;
                j++;
            }

            for (i = left; i < k; i++)
            {
                array[i] = tempArray[i];
            }

        }
    }
}