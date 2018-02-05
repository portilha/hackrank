using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Greedy
{
    [TestClass]
    public class MarcsCakewalk
    {

        static long marcsCakewalk(int[] calorie)
        {
            Array.Sort(calorie);

            long miles = 0;
            int cupcakesCount = 0;
            for (int i = calorie.Length - 1; i >= 0; i--)
            {
                miles += (calorie[i] * (long)Math.Pow(2, cupcakesCount));
                cupcakesCount++;
            }
            return miles;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(11, marcsCakewalk(new int[] { 1 ,3, 2}));
        }
    }
}
