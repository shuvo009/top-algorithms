using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc.Search
{
    public class LinearSearch
    {
        [Fact]
        public void linear_search_test()
        {
            var result = LinearSearchFunc(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 1);
            Assert.Equal(1, result);
        }

        public int LinearSearchFunc(int[] input, int item)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == item)
                    return input[i];
            }

            return -1;
        }
    }
}
