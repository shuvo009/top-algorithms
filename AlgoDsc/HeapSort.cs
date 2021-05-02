using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc
{
    public class HeapSort
    {
        [Fact]
        public void heap_sort_test()
        {
            var input = new[] { 14, 33, 27, 10, 35, 19, 42, 44 };
            HeapSortFunc(input);
            Assert.Equal(new[] { 10, 14, 19, 27, 33, 35, 42, 44 }, input);
        }

        void HeapSortFunc(int[] input)
        {
            var n = input.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heaify(input, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                Swap(input, 0, i);
                heaify(input, i, 0);
            }


        }

        void heaify(int[] array, int n, int rootIndex)
        {
            var largeIndex = rootIndex;
            var leftIndex = 2 * rootIndex + 1;
            var rightIndex = 2 * rootIndex + 2;

            if (leftIndex < n && array[leftIndex] > array[largeIndex])
                largeIndex = leftIndex;

            if (rightIndex < n && array[rightIndex] > array[largeIndex])
                largeIndex = rightIndex;

            if (largeIndex != rootIndex)
            {
                Swap(array, rootIndex, largeIndex);
                heaify(array, n, largeIndex);
            }

        }

        void Swap(int[] array, int fromIndex, int toIndex)
        {
            var temp = array[toIndex];
            array[toIndex] = array[fromIndex];
            array[fromIndex] = temp;
        }



    }
}
