using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc.Tests
{
    //Write a program to calculate the sum of a list of integers,
    //the partial integer sum could overflow, but the sum is guaranteed to be able to fit into a 32bit int type.
    public class SumOfAListOfIntegers
    {
        [Fact]
        public void Sum()
        {
            var input = new int[] { 5, int.MaxValue, -500 };
            var result = SumFunc(input);
            Assert.Equal(2147483152, result);
        }

        private int SumFunc(int[] inputs)
        {
            int sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                unchecked
                {
                    sum += inputs[i];
                }
            }

            return sum;
        }
    }
}
