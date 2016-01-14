using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace anagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6,CalculateAnagram("abc"));


        }

        int CalculateAnagram(string phrase)
        {
            int result = 1;


            for(int i=1;i<=phrase.Length;i++)
            {
                result *= i;



            }

            return result;

        }


    }
}
