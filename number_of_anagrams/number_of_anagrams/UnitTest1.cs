using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace number_of_anagrams
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, CalculateNumberofAnagram("asd"));
            Assert.AreEqual(30, CalculateNumberofAnagram("aabbf"));
        }

        int CalculateNumberofAnagram(string word)
        {
            string LowerCase = word.ToLower();
            int result;
            if (word.Length == 0)
                return 0;
            result = CalculateFactorial(LowerCase.Length) / CountRepeatedChars(LowerCase);
            return result;
        }


        int CountRepeatedChars(string string1)
        {
            int result = 0;
            int p = 1;
            for (char curentChar = 'a'; curentChar <= 'z'; curentChar++)
            {
                result = CountChars(string1, curentChar);
                p *= CalculateFactorial(result);
            }
            return p;
        }

        private static int CountChars(string sstring, char curentChar)
        {
            int result = 0;
            for (int i = 0; i < sstring.Length; i++)
            {
                if (sstring[i] == curentChar)
                {
                    result++;
                }
            }
            return result;
        }
        int CalculateFactorial(int Length)
        {
            int Number = 1;
            for (int i = 1; i <= Length; i++)
            {
                Number *= i;
            }
            return  Number;
        }






    }
}
