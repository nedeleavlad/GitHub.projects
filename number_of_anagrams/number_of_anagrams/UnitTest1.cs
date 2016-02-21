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
            Assert.AreEqual(6, GetTheNumberOfAnagram("asd"));
            Assert.AreEqual(30, GetTheNumberOfAnagram("aabbf"));
        }

        int GetTheNumberOfAnagram(string Word)
        {
            string LowerCase = Word.ToLower();
            int result;
            if (Word.Length == 0)
                return 0;
            result = GetTheFactorial(LowerCase.Length) / CountRepeatedChars(LowerCase);
            return result;
        }


        int CountRepeatedChars(string string1)
        {
            int result = 0;
            int p = 1;
            for (char charToCheck = 'a'; charToCheck <= 'z'; charToCheck++)
            {
                result = CountChars(string1, charToCheck);
                p *= GetTheFactorial(result);
            }
            return p;
        }

        private static int CountChars(string sstring, char charToCheck)
        {
            int result = 0;
            for (int i = 0; i < sstring.Length; i++)
            {
                if (sstring[i] == charToCheck)
                {
                    result++;
                }
            }
            return result;
        }
        int GetTheFactorial(int length)
        {
            int Number = 1;
            for (int i = 1; i <= length; i++)
            {
                Number *= i;
            }
            return Number;
        }






    }
}
