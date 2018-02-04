using NUnit.Framework;
using System;
namespace Strings
{
    [TestFixture()]
    public class SuperReducedString
    {

        static string super_reduced_string(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return "Empty String";

            string result = string.Empty;
            char c = s[0];
            bool changed = false;
            for (int i = 1; i < s.Length; i++)
            {
                if (c == s[i])
                {
                    c = ' ';
                    changed = true;
                }
                else
                {
                    if(c != ' ')
                       result += c;

                    c = s[i];
                }
            }

            if (c != ' ')
                result += c;

            if (changed)
                return super_reduced_string(result);

            return result;
        }


        [Test()]
        public void TestCase()
        {
            Assert.AreEqual("Empty String",super_reduced_string("baab"));
        }

        [Test()]
        public void TestCase2()
        {
            Assert.AreEqual("Empty String", super_reduced_string("aa"));
        }

        [Test()]
        public void TestCase3()
        {
            Assert.AreEqual("abd", super_reduced_string("aaabccddd"));
        }
    }
}
