using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace chesstable
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { Assert.AreEqual(204, nosquares(8));
        }
        

        int nosquares(int n)
        {
            int i, number=0;

            for(i=1;i<= n;i++)
            {
                number = number + i * i;


            }

            return number;
        }

    }
}
