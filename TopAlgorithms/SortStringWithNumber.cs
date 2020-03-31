using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TopAlgorithms
{
    class SortStringWithNumber
    {
        public void Perform()
        {
            Console.WriteLine("Sort String With Number:");
            var testData = new List<string> { "5", "2", "3", "7", "1", "11", "cat", "Apple", "dog" };
            var output = testData.OrderBy(x => x, new StringWithNumberComparer());
            Console.WriteLine(string.Join(",", output));
        }
    }

    class StringWithNumberComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            const int XGreaterThanY = 1;
            const int YGreaterThanX = -1;

            var isNumericx = int.TryParse(x, out int xn);
            var isNumericy = int.TryParse(y, out int yn);

            if (isNumericx && isNumericy)
            {
                if (xn > yn)
                {
                    return XGreaterThanY;
                }

                if (xn < yn)
                {
                    return YGreaterThanX;
                }

                return 0;
            }

            if (isNumericx)
            {
                return YGreaterThanX;
            }

            if (isNumericy)
            {
                return XGreaterThanY;
            }
            return string.Compare(x, y, true, CultureInfo.InvariantCulture);
        }
    }
}
