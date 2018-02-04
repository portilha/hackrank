using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Sorting
{
    [TestFixture()]
    public class BigSorting
    {
        static string[] bigSorting(string[] arr)
        {
            System.Collections.Generic.IComparer<string> a = new StringBigIntegerComparer();
            Array.Sort(arr, a);
            return arr;
        }

        class StringBigIntegerComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                if (x.Length > y.Length)
                    return 1;
                if (y.Length > x.Length)
                    return -1;

                for (int i = 0; i < y.Length; i++)
                {
                    if (x[i] == y[i])
                        continue;

                    int xValue = int.Parse(x[i].ToString());
                    int yValue = int.Parse(y[i].ToString());

                    return xValue > yValue ? 1 : -1;
                }

                return 0;
            }
        }

        [Test()]
        public void TestCase()
        {
                var values = new string[]{
              
"31415926535897932384626433832795",
"1",
"3",
"10",
"3",
"5"
            };

            var result = new string[]{
                "1",
"3",
"3",
"5",
"10",
"31415926535897932384626433832795"
            };

            var myResults = bigSorting(values);
            Assert.AreEqual(result, myResults);
        }
    }
}
