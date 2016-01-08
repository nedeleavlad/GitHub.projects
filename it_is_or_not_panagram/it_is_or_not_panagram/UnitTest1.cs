using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace it_is_or_not_panagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("true", findPanagram("The quick brown fox jumps over the lazy dog"));

            
        }

        string findPanagram(string phrase)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            int contor = 0;

            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < phrase.Length; j++)
                {
                    if (alphabet[i] == phrase[j]) contor++;


                }
              

           }

            if (contor == alphabet.Length) return "true";
            else return "false";


        }


    }
}
