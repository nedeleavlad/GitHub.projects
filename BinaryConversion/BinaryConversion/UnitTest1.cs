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

        [TestMethod]
        public void GetOperationAND()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(10), GetOperationAND(GetConversionToBinary(10), GetConversionToBinary(10)));
        }

        [TestMethod]
        public void GetOperationOR()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(7), GetOperationOR(GetConversionToBinary(5), GetConversionToBinary(3)));
        }

        [TestMethod]
        public void GetOperationXOR()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(6), GetOperationXOR(GetConversionToBinary(5), GetConversionToBinary(3)));
        }

        [TestMethod]
        public void IndicatePosition()
        {
            Assert.AreEqual(2, GetPosition(new byte[] { 1, 2, 3, 4 }, 2));
        }

        [TestMethod]
        public void LeftShift()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(45 << 1), GetLeftShift(GetConversionToBinary(45), 1));
        }

        [TestMethod]
        public void OperationNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 0 }, GetOperationNOT(GetConversionToBinary(61)));
        }

        [TestMethod]
        public void RightShift()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(15 >> 2), GetRightShift(GetConversionToBinary(15), 2));
        }

        private byte[] ExecuteLogicOperation(byte[] firstArray, byte[] secondArray, string getOperator)
        {
            byte[] result = new byte[Math.Max(firstArray.Length, secondArray.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = GetCases(GetPosition(firstArray, i), GetPosition(secondArray, i), getOperator);
            }
            Array.Reverse(result);
            result = RemoveZeroes(result);
            return result;
        }

        private byte GetCases(byte firstByte, byte secondByte, string getoperator)
        {
            switch (getoperator)
            {
                case "AND":
                    return (firstByte == 1) && (secondByte == 1) ? (byte)1 : (byte)0;

                case "OR":
                    return (firstByte == 1) || (secondByte == 1) ? (byte)1 : (byte)(0);

                case "XOR":
                    return (firstByte) != (secondByte) ? (byte)(1) : (byte)(0);
            }
            return 0;
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

        private byte[] GetLeftShift(byte[] array, int digits)
        {
            Array.Resize(ref array, array.Length + digits);

            return array;
        }

        private byte[] GetOperationAND(byte[] firstArray, byte[] secondArray)
        {
            return ExecuteLogicOperation(firstArray, secondArray, "AND");
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

        private byte[] GetOperationOR(byte[] firstArray, byte[] secondArray)
        {
            return ExecuteLogicOperation(firstArray, secondArray, "OR");
        }

        private byte[] GetOperationXOR(byte[] firstArray, byte[] secondArray)
        {
            return ExecuteLogicOperation(firstArray, secondArray, "XOR");
        }

        private byte GetPosition(byte[] array, int position)
        {
            if (position < array.Length)
                return array[array.Length - position - 1];

            return 0;
        }

        private byte[] GetRightShift(byte[] array, int position)
        {
            Array.Reverse(array);

            Array.Resize(ref array, array.Length - position);

            Array.Reverse(array);

            return array;
        }

        private byte[] RemoveZeroes(byte[] bytes)
        {
            int counter = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] == 0)
                    counter++;
                else
                    break;
            }
            bytes = GetRightShift(bytes, counter);
            return bytes;
        }
    }
}