using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int index = 0;
            Assert.AreEqual(10, Calculate("+ + 4 4 + 1 1", ref index));
        }

        private double Calculate(string givenString, ref int index)
        {
            string[] elements = givenString.Split(' ');

            string first = elements[index++];

            double number;

            if (Double.TryParse(first, out number))
            {
                return number;
            }

            return GetMathematicalOperations(givenString, ref index, first);
        }

        private double GetMathematicalOperations(string givenString, ref int index, string operation)
        {
            switch (operation)
            {
                case "+": return Calculate(givenString, ref index) + Calculate(givenString, ref index);
                case "*": return Calculate(givenString, ref index) * Calculate(givenString, ref index);
                case "/": return Calculate(givenString, ref index) / Calculate(givenString, ref index);
                default: return Calculate(givenString, ref index) - Calculate(givenString, ref index);
            }
        }
    }
}