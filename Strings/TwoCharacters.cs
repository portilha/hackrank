using NUnit.Framework;
using System;
namespace Strings
{
    [TestFixture()]
    public class TwoCharacters
    {

        static int twoCharaters(string s)
        {
            string res = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {

            }

            return res.Length;
        }


        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(5, twoCharaters("beabeefeab"));
        }
    }
}
