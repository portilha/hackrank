

using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Strings
{
    [TestFixture()]
    public class TwoCharacters
    {

        static HashSet<char> charCount;

        static int twoCharaters(string s)
        {
            charCount = new HashSet<char>();

            int maxSize = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                char marked = s[i];
               
                if (!charCount.Contains(marked))
                {
                    charCount.Add(marked);

                    HashSet<char> tested = new HashSet<char>();

                    for (int j = i + 1; j < s.Length; j++)
                    {
                        char second = s[j];
                        if (second == marked) // There is no more change to have a sequence.
                            break;

                        if (charCount.Contains(second) || tested.Contains(second))
                            continue;

                        tested.Add(second);

                        maxSize = Math.Max(maxSize, isSequence(marked, s, j));
                    }

                }
            }

            return maxSize;
        }

        private static int isSequence(char first, string s, int index)
        {
            char second = s[index];
            if (first == second)
                return 0;

            string result = first.ToString() + second.ToString();

            bool checkFirst = true;
            int size = 2;
            for (int i = index + 1; i < s.Length; i++)
            {
                if (s[i] == first)
                {
                    if (!checkFirst)
                        return 0;

                    checkFirst = false;
                    size++;
                    result += first.ToString();
                }
                else if (s[i] == second)
                {
                    if (checkFirst)
                        return 0;

                    result += second.ToString();
                    size++;
                    checkFirst = true;
                }
            }

            if (size > 0)
                Console.WriteLine(result);

            return size;
        }


        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(5, twoCharaters("beabeefeab"));
        }

        [Test()]
        public void TestCase2()
        {
            Assert.AreEqual(0, twoCharaters("uyetuppelecblwipdsqabzsvyfaezeqhpnalahnpkdbhzjglcuqfjnzpmbwprelbayyzovkhacgrglrdpmvaexkgertilnfooeazvulykxypsxicofnbyivkthovpjzhpohdhuebazlukfhaavfsssuupbyjqdxwwqlicbjirirspqhxomjdzswtsogugmbnslcalcfaxqmionsxdgpkotffycphsewyqvhqcwlufekxwoiudxjixchfqlavjwhaennkmfsdhigyeifnoskjbzgzggsmshdhzagpznkbahixqgrdnmlzogprctjggsujmqzqknvcuvdinesbwpirfasnvfjqceyrkknyvdritcfyowsgfrevzon"));
        }

        [Test()]
        public void Test3()
        {
            Assert.AreEqual(0, twoCharaters("yviazlmiebxllgsjzsbncdsyhqetbcabuademkpyllahuoactpxolunzmgknxxxuimpyybzynblohxygdmpihyhvkszpbvpkclesljnbgbiccwhmzsykigojxuaqvyyrcoepyynuaagnlrsttfzwhyngnwkcebzdwbmvpbfhocshnczrpdjwuveajxjalguamiunouiivsgeftnggdaeqennlvzcoswrdwogwlpysrjkcdlgkpwsgdzpyognjrxvzilxienerghdtfbcbvkdjtibmyiseaitznkulnoqzugkraswpjcmrabmpzthfkvravvklifydrydbbfmjfqgowdchsghftkssafnjdkwzwykulghbsijggnl"));
        }

        [Test()]
        public void Test8()
        {
            Assert.AreEqual(8, twoCharaters("cwomzxmuelmangtosqkgfdqvkzdnxerhravxndvomhbokqmvsfcaddgxgwtpgpqrmeoxvkkjunkbjeyteccpugbkvhljxsshpoymkryydtmfhaogepvbwmypeiqumcibjskmsrpllgbvc"));
        }
    }
}
