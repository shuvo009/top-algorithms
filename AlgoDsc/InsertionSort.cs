using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc
{
    public class InsertionSort
    {
        [Fact]
        public void Insertion_sort_test()
        {
            var result = InsertionSortFunc(new[] { 14, 33, 27, 10, 35, 19, 42, 44 });
            Assert.Equal(new[] { 10, 14, 19, 27, 33, 35, 42, 44 }, result);
        }

        public int[] InsertionSortFunc(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                var value = input[i];
                var j = i;
                while (j > 0 && input[j - 1] > value)
                {
                    input[j] = input[j - 1];
                    j--;
                }

                input[j] = value;
            }
            return input;
        }
    }
}
