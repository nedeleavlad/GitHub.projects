using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//11001
namespace BinaryConversion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BinaryConverionfor61()
        {
            CollectionAssert.AreEqual(new byte[] { 1,1,1,1,0,1}, GetConversionToBinary(61));

        }

        byte[] GetConversionToBinary(int number)
        {
            byte[] byteArray = new byte[0];

            int contor = 0;

            while (number > 0)
            {
                Array.Resize(ref byteArray, byteArray.Length + 1);

                byteArray[contor] = (byte)(number % 2);


                contor += 1;

                number = number / 2;


            }

            Array.Reverse(byteArray);

            return byteArray;

        }


    }
}
