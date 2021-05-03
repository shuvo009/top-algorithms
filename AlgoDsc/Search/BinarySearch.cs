using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc.Search
{
    public class BinarySearch
    {
        [Fact]
        public void binary_search_test()
        {
            var input = new[] { 1, 2, 3, 4, 6 };
            var result = BinarySearchFunc(input, 0, input.Length-1, 4);
            Assert.Equal(4, result);
        }

        public int BinarySearchFunc(int[] input, int start, int end, int target)
        {
            if (start > end)
                return -1;
            var middle = (start + end) / 2;
            if (input[middle] == target)
                return input[middle];

            if (input[middle] > target)
                return BinarySearchFunc(input, 0, middle, target);

            return BinarySearchFunc(input, middle + 1, end, target);
        }

    }
}
