using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc.Search
{
    public class InterpolationSearch
    {
        [Fact]
        public void Interpolation_search_test()
        {
            var input = new[] { 1, 2, 3, 4, 6 };
            var result = InterpolationSearchFunc(input, 6);
            Assert.Equal(4, result);
        }

        //Positioning in Binary Search
        public int InterpolationSearchFunc(int[] input, int target)
        {
            int lo = 0;
            int hi = input.Length - 1;
            int mid = 0;
            while (input[mid] != target)
            {
                if (lo >= hi)
                {
                    return -1;
                }

                mid = lo + ((hi - lo) / (input[hi] - input[lo])) * (target - input[lo]);

                if (input[mid] == target)
                {
                    return mid;
                }
                else
                {
                    if (input[mid] < target)
                        lo = mid + 1;
                    else
                        hi = mid - 1;
                }
            }

            return mid;
        }
    }

}
