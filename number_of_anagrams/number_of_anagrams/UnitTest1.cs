using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace number_of_anagrams
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetNumberofAnagrams1()
        {
            Assert.AreEqual(3, CalculateNumberofAnagram("aab"));
           
        }
        [TestMethod]
        public void GetNumberofAnagramsforSameCharacters()
        {
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


        int CountRepeatedChars(string givenString)
        {
            int result = 0;
            int p = 1;
            for (char curentChar = 'a'; curentChar <= 'z'; curentChar++)
            {
                result = CountChars(givenString, curentChar);
                p *= CalculateFactorial(result);
            }
            return p;
        }

        private static int CountChars(string curentString, char curentChar)
        {
            int result = 0;
            for (int i = 0; i < curentString.Length; i++)
            {
                if (curentString[i] == curentChar)
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
            return Number;
        }






    }
}
