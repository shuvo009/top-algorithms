using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc
{
    public class SelectionSort
    {
        [Fact]
        public void Selection_sort_test()
        {
            var result = SelectionSortFunc(new[] { 14, 33, 27, 10, 35, 19, 42, 44 });
            Assert.Equal(new[] { 10, 14, 19, 27, 33, 35, 42, 44 }, result);
        }


        public int[] SelectionSortFunc(int[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var minIndex = i;
             
                for (var j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < input[minIndex])
                    {
                        minIndex = j;
                    }
                }

                var temp = input[minIndex];
                input[minIndex] = input[i];
                input[i] = temp;
            }

            return input;
        }
    }
}
