using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaryConversion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AditionOperation()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(12), GetOperationAdition(GetConversionToBinary(10), GetConversionToBinary(2)));

            CollectionAssert.AreEqual(GetConversionToBinary(23), GetOperationAdition(GetConversionToBinary(15), GetConversionToBinary(8)));
        }

        [TestMethod]
        public void BinaryConversionfor61()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 0, 1 }, GetConversionToBinary(61));
        }

        [TestMethod]
        public void GetBiggerFactorial()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(1), CalculateFactorial(GetOperationDivision(GetConversionToBinary(49), GetConversionToBinary(48))));
        }

        [TestMethod]
        public void GetEqual()
        {
            Assert.IsTrue(GetEqualOperation(GetConversionToBinary(14), GetConversionToBinary(14)));
            Assert.IsFalse(GetEqualOperation(GetConversionToBinary(9), GetConversionToBinary(8)));
        }

        [TestMethod]
        public void GetNotEqual()
        {
            Assert.IsTrue(GetNotEqualOperation(GetConversionToBinary(3), GetConversionToBinary(7)));
            Assert.IsFalse(GetNotEqualOperation(GetConversionToBinary(14), GetConversionToBinary(14)));
        }

        [TestMethod]
        public void GetOperationAND()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(10), GetOperationAND(GetConversionToBinary(10), GetConversionToBinary(10)));
        }

        [TestMethod]
        public void GetOperationGreaterThan()
        {
            Assert.IsTrue(GetGreaterThanOperation(GetConversionToBinary(6), GetConversionToBinary(2)));
            Assert.IsFalse(GetGreaterThanOperation(GetConversionToBinary(6), GetConversionToBinary(80)));
            Assert.IsFalse(GetGreaterThanOperation(GetConversionToBinary(8), GetConversionToBinary(8)));
        }

        [TestMethod]
        public void GetOperationLessThan()
        {
            Assert.IsTrue(GetLessThanOperation(GetConversionToBinary(1), GetConversionToBinary(5)));

            Assert.IsFalse(GetLessThanOperation(GetConversionToBinary(60), GetConversionToBinary(5)));

            Assert.IsFalse(GetLessThanOperation(GetConversionToBinary(5), GetConversionToBinary(5)));
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
        public void GetSmallFactorial()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(24), CalculateFactorial(GetConversionToBinary(4)));
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
        public void OperationDivision()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(11), GetOperationDivision(GetConversionToBinary(22), GetConversionToBinary(2)));
            CollectionAssert.AreEqual(new byte[] { 0 }, GetOperationDivision(GetConversionToBinary(5), GetConversionToBinary(7)));
        }

        [TestMethod]
        public void OperationMultiplication()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(200), GetOperationMultiplication(GetConversionToBinary(100), GetConversionToBinary(2)));
        }

        [TestMethod]
        public void OperationNOT()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 0 }, GetOperationNOT(GetConversionToBinary(61)));
        }

        [TestMethod]
        public void OperationSubstraction()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(10), GetOperationSubstraction(GetConversionToBinary(15), GetConversionToBinary(5)));
        }

        [TestMethod]
        public void RightShift()
        {
            CollectionAssert.AreEqual(GetConversionToBinary(15 >> 2), GetRightShift(GetConversionToBinary(15), 2));
        }

        private byte[] CalculateFactorial(byte[] byteArray)
        {
            byte[] result = { 1 };
            byte[] bytesOne = { 0 };
            while (GetNotEqualOperation(byteArray, new byte[] { 0 }))
            {
                result = GetOperationMultiplication(byteArray, result);
                byteArray = GetOperationSubstraction(byteArray, new byte[] { 1 });
                byteArray = RemoveZeroes(byteArray);
            }
            return result;
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

        private bool GetEqualOperation(byte[] bytesOne, byte[] bytesTwo)
        {
            return !(GetNotEqualOperation(bytesOne, bytesTwo));
        }

        private bool GetGreaterThanOperation(byte[] bytesOne, byte[] bytesTwo)
        {
            return GetLessThanOperation(bytesTwo, bytesOne);
        }

        private byte[] GetLeftShift(byte[] array, int digits)
        {
            Array.Resize(ref array, array.Length + digits);

            return array;
        }

        private bool GetLessThanOperation(byte[] firstByte, byte[] secondByte)
        {
            byte[] emptyArray = new byte[0];
            for (int i = Math.Max(firstByte.Length, secondByte.Length) - 1; i >= 0; i--)
            {
                if (GetPosition(firstByte, i) < GetPosition(secondByte, i))
                    return true;
                if (GetPosition(firstByte, i) > GetPosition(secondByte, i))
                    return false;
            }
            return false;
        }

        private bool GetNotEqualOperation(byte[] bytesOne, byte[] bytesTwo)
        {
            return (GetLessThanOperation(bytesOne, bytesTwo) || GetGreaterThanOperation(bytesOne, bytesTwo));
        }

        private byte[] GetOperationAdition(byte[] firstByteArray, byte[] secondByteArray)
        {
            byte[] result = new byte[Math.Max(secondByteArray.Length, firstByteArray.Length)];
            int counter = 0;
            for (int i = 0; i < result.Length; i++)
            {
                var sum = (GetPosition(firstByteArray, i) + GetPosition(secondByteArray, i) + counter);
                result[i] = (byte)(sum % 2);
                counter = sum / 2;
            }

            if (counter == 1)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = (byte)counter;
            }

            Array.Reverse(result);
            return result;
        }

        private byte[] GetOperationAND(byte[] firstArray, byte[] secondArray)
        {
            return ExecuteLogicOperation(firstArray, secondArray, "AND");
        }

        private byte[] GetOperationDivision(byte[] firstByte, byte[] secondByte)
        {
            byte[] result = { 0 };
            if (GetLessThanOperation(firstByte, secondByte))
                return new byte[] { 0 };
            while (GetGreaterThanOperation(firstByte, secondByte) || GetEqualOperation(firstByte, secondByte))
            {
                firstByte = GetOperationSubstraction(firstByte, secondByte);
                result = GetOperationAdition(result, new byte[] { 1 });
            }
            return result;
        }

        private byte[] GetOperationMultiplication(byte[] firstArray, byte[] secondArray)
        {
            byte[] result = { 0 };
            while (GetNotEqualOperation(firstArray, new byte[] { 0 }))
            {
                result = GetOperationAdition(secondArray, result);
                firstArray = GetOperationSubstraction(firstArray, new byte[] { 1 });
            }

            return result;
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

        private byte[] GetOperationSubstraction(byte[] firstByteArray, byte[] secondByteArray)
        {
            byte[] result = new byte[Math.Max(secondByteArray.Length, firstByteArray.Length)];
            int counter = 0;
            for (int i = 0; i < result.Length; i++)
            {
                var substract = 2 + GetPosition(firstByteArray, i) - GetPosition(secondByteArray, i) - counter;
                result[i] = (byte)(substract % 2);
                counter = (substract < 2) ? 1 : 0;
            }
            Array.Reverse(result);
            result = RemoveZeroes(result);

            return result;
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
                if (!(bytes[i] == 0)) break;
                counter++;
            }
            bytes = GetRightShift(bytes, counter);
            return bytes;
        }
    }
}