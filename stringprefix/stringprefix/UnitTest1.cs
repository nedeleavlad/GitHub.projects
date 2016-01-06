using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace stringprefix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("aa", prefix("aab","aaf"));

        }
        
        string prefix(string s1, string s2)
        {
            string ss = string.Empty;
            int i, j;

               for(i=0;i<s1.Length;i++)
                 {  for(j=0;j<s2.Length;j++)
                       {   if (s1[i] == s2[j])

                                  {
                                    ss+=s2[j];
                                   }
                        }


                  }
            return ss;

        }



    }
}
