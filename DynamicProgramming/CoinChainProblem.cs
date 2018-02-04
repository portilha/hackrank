using NUnit.Framework;
using System;
namespace DynamicProgramming
{
    [TestFixture()]
    public class CoinChainProblem
    {
        internal static long[,] totals;

        internal static long getWays(long total, long[] coinValues, int coinTotal)
        {
            totals = new long[total + 1, coinTotal + 1];

            totals[0, 0] = 1;

            for (int i = 1; i <= total; i++)
            {
                totals[i, 0] = 0;
            }

            for (int t = 0; t <= total; t++)
            {
                for (int coin = 1; coin <= coinTotal; coin++)
                {
                    totals[t, coin] = totals[t, coin - 1];
                    var innerTotal = t - coinValues[coin - 1];
                    if (innerTotal >= 0)
                        totals[t, coin] += totals[innerTotal, coin];
                }
            }

            return totals[total, coinTotal];
        }


        [Test()]
        public void TestCase()
        {
            Assert.AreEqual((long)4, getWays(4, new long[] { 1, 2, 3 }, 3));
        }

        [Test()]
        public void TestCase2()
        {
            Assert.AreEqual(5, getWays(10, new long[] { 2, 5, 3, 6 }, 4));
        }

        [Test()]
        public void TestCaseDynamicProgramming()
        {
            Assert.AreEqual(168312708, getWays(219, new long[] { 36, 10, 42, 7, 50, 1, 49, 24, 37, 12, 34, 13, 39, 18, 8, 29, 19, 43, 5, 44, 28, 23, 35, 26 }, 24));
        }

    }
}
