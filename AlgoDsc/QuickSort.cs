using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc
{
    public class QuickSort
    {
        [Fact]
        public void Quick_sort_test()
        {
            var input = new[] { 14, 33, 27, 10, 35, 19, 42, 44 };
            QuickSortFunc(input, 0, input.Length - 1);
            Assert.Equal(new[] { 10, 14, 19, 27, 33, 35, 42, 44 }, input);
        }

        private void QuickSortFunc(int[] array, int start, int end)
        {
            if (start >= end)
                return;
            var pivot = Partition(array, start, end);
            QuickSortFunc(array, start, pivot - 1);
            QuickSortFunc(array, pivot + 1, end);
        }

        private int Partition(int[] array, int start, int end)
        {
            var pivot = array[end];
            var pIndex = start;
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
    }
}
