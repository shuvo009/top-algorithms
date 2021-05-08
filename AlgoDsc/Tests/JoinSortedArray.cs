using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc.Tests
{
    public class JoinSortedArray
    {
        [Fact]
        public void Join_sorted_array_test()
        {
            var result = JoinSortedArrayFunc(new[]{1,3,4,6}, new[]{1,2,3,5,7});
            Assert.Equal(new[] {1, 2, 3, 4, 5, 6, 7}, result);
        }

        private int[] JoinSortedArrayFunc(int[] arrayOne, int[] arrayTwo)
        {
            var list = new List<int>();
            list.AddRange(arrayOne.ToList());
            list.AddRange(arrayTwo.ToList());

            return list.Distinct().OrderBy(x => x).ToArray();
        }
    }
}
