using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc
{
    public class CharSort
    {
        [Fact]
        public void Chart_sort_test()
        {
            var result = CharSortFunc("acebfd");
            Assert.Equal("abcdef", result);
        }


        public string CharSortFunc(string input)
        {
            var charList = input.ToCharArray();

            for (int i = 0; i < charList.Length - 1; i++)
            {
                for (int j = i + 1; j < charList.Length; j++)
                {
                    if (charList[i] > charList[j])
                    {
                        var temp = charList[i];
                        charList[i] = charList[j];
                        charList[j] = temp;
                    }
                }
            }

            return new string(charList);
        }
    }
}
