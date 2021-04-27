using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc
{
    public class BubbleSort
    {
        [Fact]
        public void Bubble_sort_test()
        {
            var result = BubbleSortFunc(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        public int[] BubbleSortFunc(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        var temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }

            return input;
        }
    }
}
