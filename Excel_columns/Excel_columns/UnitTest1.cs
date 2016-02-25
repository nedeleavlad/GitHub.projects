using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel_columns
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetConvertfor1()
        {
            Assert.AreEqual("a", GetConvertedColumn(1));
        }


        [TestMethod]
        public void GetConvertfor26()
        {
            Assert.AreEqual("z", GetConvertedColumn(26));
        }

        [TestMethod]
        public void GetConvertfor27()
        {
            Assert.AreEqual("aa", GetConvertedColumn(27));
        }

        string GetConvertedColumn(int columns)
        {
            string result = string.Empty;
            while (--columns >= 0)
            {
                result += GetLetter(columns % 26);
                columns = columns / 26;
            }
            return result;
        }

        char GetLetter(int CurrentLetter)
        {
            return (char)('a' + CurrentLetter);
        }


    }
}
