using NUnit.Framework;
using System;
namespace Recursion
{
    [TestFixture()]
    public class RecursiveDigitSum
    {
        static int digitSum(string n, int k)
        {
            // Complete this function

            // int.Parse(n) * k;
            long sum = 0;
            foreach (char val in n)
            {
                sum += int.Parse(val.ToString());
            }

            long superDigit = sum * k;

            while (superDigit > 10)
            {
                sum = 0;
                foreach (char val in superDigit.ToString())
                {
                    sum += int.Parse(val.ToString());
                }
                superDigit = sum;
            }
            return (int)superDigit;
        }


        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(3, digitSum("148",3));
        }
    }
}
