using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvertString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInvertString()
        {
            Assert.AreEqual("adfg", GetStringInverted("gfda"));
        }

        public string GetStringInverted(string givenString)
        {
            if (givenString.Length == 1) return givenString;

            return givenString[givenString.Length - 1] + GetStringInverted(givenString.Substring(0, givenString.Length - 1));
        }
    }
}