using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc.Tests
{
    public class SumContiguousSubArray
    {
        [Fact]
        public void Sum_contiguous_sub_array()
        {
            var input = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            var result = GetMaxSumContiguousSubArray(input);
            Assert.Equal(7, result);
        }

        private int GetMaxSumContiguousSubArray(int[] input)
        {
            var maxSoFar = 0;
            var maxEndingHere = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var val = input[i];
                maxEndingHere += val;
                
                if (maxEndingHere < 0)
                    maxEndingHere = 0;

                if (maxEndingHere > maxSoFar)
                    maxSoFar = maxEndingHere;
            }

            return maxSoFar;
        }
    }
}
