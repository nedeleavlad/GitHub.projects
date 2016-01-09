using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace it_is_or_not_panagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("true", FindPanagram("The quick brown fox jumps over the lazy dog"));

            Assert.AreEqual("false", FindPanagram("aaaa"));
        }

        string FindPanagram(string phrase)
        {
            

            for (int j = 0; j < phrase.Length; j++)
            {
                if (FindLetter(phrase[j]) == false) return "false";
                           else return "true";



            }
        }


        bool FindLetter(char letter)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for(int i=0;i<alphabet.Length;i++)
            {
                if (letter == alphabet[i]) return true;
                else return false;


            }



        }





    }
}
