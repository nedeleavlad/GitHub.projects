using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Replace_Letter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReplaceTest()
        {
            Assert.AreEqual("mccmcc", ChangeLetterWithString("mama", 'a', "cc"));
        }

        public string ChangeLetterWithString(string givenString, char letterToChange, string newString)
        {
            if (givenString.Length > 0)
            {
                if (givenString[0] == letterToChange) return newString + ChangeLetterWithString(givenString.Substring(1), letterToChange, newString);
                return givenString[0] + ChangeLetterWithString(givenString.Substring(1), letterToChange, newString);
            }
            return givenString;
        }
    }
}