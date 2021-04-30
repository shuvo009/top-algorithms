using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc
{
    public class MargeSort
    {
        [Fact]
        public void Marge_sort_test()
        {
            var result = MargeSortFunc(new[] { 14, 33, 27, 10, 35, 19, 42, 44 });
            Assert.Equal(new[] { 10, 14, 19, 27, 33, 35, 42, 44 }, result);
        }

        public int[] MargeSortFunc(int[] input)
        {
            if (input.Length == 1)
                return input;

            var middle = input.Length / 2;
            var leftArray = MargeSortFunc(CopyToArray(input, 0, middle));
            var rightArray = MargeSortFunc(CopyToArray(input, middle, input.Length));

            return Marge(leftArray, rightArray);
        }

        public int[] CopyToArray(int[] input, int start, int end)
        {
            var array = new int[end - start];
            var j = 0;
            for (var i = start; i < end; i++)
            {
                array[j++] = input[i];
            }

            return array;
        }

        public int[] Marge(int[] leftArray, int[] rightArray)
        {
            var mergedArray = new int[leftArray.Length + rightArray.Length];

            var leftArrayIndex = 0;
            var rightArrayIndex = 0;
            var mergedArrayIndex = 0;

            while (leftArrayIndex < leftArray.Length && rightArrayIndex < rightArray.Length)
            {
                if (leftArray[leftArrayIndex] < rightArray[rightArrayIndex])
                {
                    mergedArray[mergedArrayIndex++] = leftArray[leftArrayIndex++];
                }
                else
                {
                    mergedArray[mergedArrayIndex++] = rightArray[rightArrayIndex++];
                }
            }

            while (leftArrayIndex < leftArray.Length)
            {
                mergedArray[mergedArrayIndex++] = leftArray[leftArrayIndex++];
            }

            while (rightArrayIndex < rightArray.Length)
            {
                mergedArray[mergedArrayIndex++] = rightArray[rightArrayIndex++];
            }

            return mergedArray;
        }
    }
}
