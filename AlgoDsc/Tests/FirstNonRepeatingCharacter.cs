using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoDsc.Tests
{
    public class FirstNonRepeatingCharacter
    {
        [Fact]
        public void First_non_repeating_character()
        {
            var input = "abcdacdvbaef";
            var result = GetFirstNonRepeatingCharacter(input);
            Assert.Equal('v', result);
        }

        private char GetFirstNonRepeatingCharacter(string input)
        {
            var hashTable = new Dictionary<char, int>();

            var chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                var ch = chars[i];
                if (hashTable.ContainsKey(ch))
                    hashTable[ch] += 1;
                else
                    hashTable[ch] = 1;
            }

            foreach (var ht in hashTable)
            {
                if (ht.Value == 1)
                    return ht.Key;
            }

            return ' ';
        }
    }
}
