using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace stringprefix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("aaa", findPrefix("aaab","aaaf"));

            Assert.AreEqual("aaa", findPrefix("aaa", "aaab"));

            Assert.AreEqual("", findPrefix("ss", "ggg"));
            
        }
        
        string findPrefix(string firstPhrase, string secondPhrase)
        {
            string result = string.Empty;

            for (int i = 0; i < System.Math.Min(firstPhrase.Length, secondPhrase.Length) ;i ++)

            {    if (firstPhrase[i] == secondPhrase[i]) result += firstPhrase[i];
                else break;


            }


                  
            return result;

        }



    }
}
