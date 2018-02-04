using NUnit.Framework;
using System;
namespace Strings
{
    [TestFixture()]
    public class CamelCase
    {
        static int camelcase(string s)
        {
            int total = 1;
            // Complete this function
            foreach (char item in s)
            {
                total += char.IsUpper(item) ? 1 : 0;
            }

            return total;
        }


        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(5, camelcase("saveChangesInTheEditor"));
        }
    }
}
