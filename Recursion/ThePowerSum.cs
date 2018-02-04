using NUnit.Framework;
using System;
namespace Recursion
{
    [TestFixture()]
    public class ThePowerSum
    {


        static int powerSum(int X, int P, int N = 1)
        {
            int i_pow = (int)Math.Pow(N, P);
            if (i_pow > X)
                return 0;
            else if (i_pow == X)
                return 1;
            // subproblem
            return powerSum(X, P, N + 1) + 
                   powerSum(X - i_pow, P, N + 1);
        }



        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(2, powerSum(10,2));
        }

        [Test()]
        public void TestCase2()
        {
            Assert.AreEqual(3, powerSum(100, 2));
        }

        [Test()]
        public void TestCase3()
        {
            Assert.AreEqual(1, powerSum(100, 3));
        }

    }
}
