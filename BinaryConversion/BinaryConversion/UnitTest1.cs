using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        private byte[] GetConversionToBinary(int number)
        {
            byte[] byteArray = new byte[0];

            if (number == 0) return new byte[] { 0 };

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

        private byte[] GetOperationNOT(byte[] byteArray)
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

        private byte GetPosition(byte[] array, int position)
        {
            if (position < array.Length)
                return array[array.Length - position - 1];

            return 0;
        }

        [TestMethod]
        public void GetOperationAND()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(10), GetOperationAND(GetConversionToBinary(10), GetConversionToBinary(10)));
        }

        private byte[] GetOperationAND(byte[] firstArray, byte[] secondArray)
        {
            return ExecuteLogicOperation(firstArray, secondArray, "AND");
        }

        [TestMethod]
        public void GetOperationOR()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(7), GetOperationOR(GetConversionToBinary(5), GetConversionToBinary(3)));
        }

        private byte[] GetOperationOR(byte[] firstArray, byte[] secondArray)
        {
            return ExecuteLogicOperation(firstArray, secondArray, "OR");
        }

        [TestMethod]
        public void GetOperationXOR()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(6), GetOperationXOR(GetConversionToBinary(5), GetConversionToBinary(3)));
        }

        private byte[] GetOperationXOR(byte[] firstArray, byte[] secondArray)
        {
            return ExecuteLogicOperation(firstArray, secondArray, "XOR");
        }

        private void GetCases(byte[] firstArray, byte[] secondArray, string getoperator, byte[] result, int i)
        {
            switch (getoperator)
            {
                case "AND":
                    result[i] = (GetPosition(firstArray, i) == 1 && GetPosition(secondArray, i) == 1) ? (byte)1 : (byte)0;
                    break;

                case "OR":
                    result[i] = (GetPosition(firstArray, i) == 1 || GetPosition(secondArray, i) == 1) ? (byte)(1) : (byte)(0);
                    break;

                case "XOR":
                    result[i] = (GetPosition(firstArray, i) != GetPosition(secondArray, i)) ? (byte)(1) : (byte)(0);
                    break;
            }
        }

        private byte[] ExecuteLogicOperation(byte[] firstArray, byte[] secondArray, string getOperator)
        {
            byte[] result = new byte[Math.Max(firstArray.Length, secondArray.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                GetCases(firstArray, secondArray, getOperator, result, i);
            }
            Array.Reverse(result);
            return result;
        }
    }
}