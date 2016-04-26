using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fibonacci_row
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fibonacci()
        {
            Assert.AreEqual(13, GetFibonacciRow(7));
        }

        public int GetFibonacciRow(int number)
        {
            if (number < 2) return number;

            return (GetFibonacciRow(number - 1) + GetFibonacciRow(number - 2));
        }
    }
}