using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc.Tests
{
    //Find the numbers in the loop that the summation of which equal to some number
    public class FindSumOfNumber
    {
        [Fact]
        public void Find_sum_of_number()
        {
            var input = new[] { 1, 4, 45, 6, 10, -8 };
            var result = FindSumOfNumberFunc(input, 16);
            Assert.True(result);
        }

        private bool FindSumOfNumberFunc(int[] input, int sum)
        {
            Array.Sort(input);

            var start = 0;
            var end = input.Length-1;

            while (start!=end)
            {
                if (input[start] + input[end] > sum)
                {
                    end--;
                }
                else if (input[start] + input[end] < sum)
                {
                    start++;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
