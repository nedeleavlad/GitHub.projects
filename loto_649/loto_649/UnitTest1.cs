using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace loto_649
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateProbability()
        {
            Assert.AreEqual(1.84498995124078E-05, GetProbability(49, 6, 5));
        }
        [TestMethod]
        public void CalculateCombinations()
        {
            Assert.AreEqual(13983816, GetCombinations(49, 6));
        }


        double GetFactorial(int number)
        {
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;

        }

        double GetCombinations(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                return 1;
            }

            else if (secondNumber > firstNumber)
            {
                return 0;
            }
            else return (GetCombinations(firstNumber - 1, secondNumber) + GetCombinations(firstNumber - 1, secondNumber - 1));
        }

        double GetProbability(int numberoftheBalls, int noBallsSingleTicket, int noBallsWinningTicket)
        {
            double probability = 0;

            probability = probability + ((GetCombinations(noBallsSingleTicket, noBallsWinningTicket) * GetCombinations(numberoftheBalls - noBallsSingleTicket, noBallsSingleTicket - noBallsWinningTicket)) / GetCombinations(numberoftheBalls, noBallsSingleTicket));



            return probability;
        }


    }

}

