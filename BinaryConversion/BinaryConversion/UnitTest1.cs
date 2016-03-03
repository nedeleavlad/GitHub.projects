﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//11001
namespace BinaryConversion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BinaryConversionfor61()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 0, 1 }, GetConversionToBinary(61));

        }

        byte[] GetConversionToBinary(int number)
        {
            byte[] byteArray = new byte[0];

            while (number > 0)
            {
                Array.Resize(ref byteArray, byteArray.Length + 1);

                byteArray[byteArray.Length - 1] = (byte)(number % 2);

                number = number / 2;
            }

            Array.Reverse(byteArray);

            return byteArray;
        }

        [TestMethod]
        public void OperationNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 0 }, GetOperationNOT(GetConversionToBinary(61)));

        }

        byte[] GetOperationNOT(byte[] byteArray)
        {
            byte[] result = new byte[0];

            for (int i = 0; i < byteArray.Length; i++)

            {
                Array.Resize(ref result, result.Length + 1);

                result[i] = ((byteArray[i]) == 1) ? ((byte)0) : ((byte)1);

            }

            return result;
        }

        [TestMethod]
        public void IndicatePosition()
        {
            Assert.AreEqual(2, GetPosition(new byte[] { 1, 2, 3, 4 }, 2));
        }


        byte GetPosition(byte[] array, int position)
        {
            if (position < array.Length)
                return array[array.Length - position - 1];

            return 0;
        }

        [TestMethod]
        public void GetOperationAND()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(10),OperationAND(GetConversionToBinary(10), GetConversionToBinary(10)));
        }



       byte[] OperationAND(byte[] firstArray, byte[] secondArray)
        {
            byte[] result = new byte[Math.Max(firstArray.Length, secondArray.Length)];

            for(int i=0;i<result.Length;i++)
            {
                result[i]= (GetPosition(firstArray, i) == 1 && GetPosition(secondArray,i) == 1) ? (byte)1 : (byte)0;

            }
            Array.Reverse(result);
            return result;
        }


    }
}
