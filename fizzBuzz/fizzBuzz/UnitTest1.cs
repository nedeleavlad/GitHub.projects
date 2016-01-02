using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fizzBuzz
{
    [TestClass]
    public class FizzbuzzP
    {
        [TestMethod]
        public void FizzTest()
        {
            Assert.AreEqual('FIZZ', fb(6));
        }

        [TestMethod]
        public void BuzzTest()
        {
            Assert.AreEqual('BUZZ', fb(5));
        }



        [TestMethod]
        public void FizzBuzzTest()
        {
            Assert.AreEqual('FIZZBUZZ', fb(15));
        }


        [TestMethod]
        public void FizzBuzzTest1()
        {
            Assert.AreEqual('The number is not fizzbuzz', fb(16));
        }


    }

    int fb (int number )
    {

        if ((number % 3 == 0) && (number % 5 == 0)) return 'FIZZBUZZ';

        else if (number % 3 == 0) return 'FIZZ';

        else if (number % 5 == 0) return 'BUZZ';

        else return 'The number is not fizzbuzz';

    }


}
