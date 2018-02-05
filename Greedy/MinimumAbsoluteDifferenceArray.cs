using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Greedy
{
    [TestClass]
    public class MinimumAbsoluteDifferenceArray
    {

        static int minimumAbsoluteDifference(int n, int[] arr)
        {
            Array.Sort(arr);
            int minValue = int.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minValue = Math.Min(minValue, Math.Abs(arr[i] - arr[i + 1]));
            }
            return minValue;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, minimumAbsoluteDifference(3, new int[] { 3, -7, 0 }));
        }
    }
}
