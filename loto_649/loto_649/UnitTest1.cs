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
            Assert.AreEqual(5.244158E-07, (double)GetProbability(6, 2, 5, 49));
        }
        [TestMethod]
        public void CalculateCombinations()
        {
            Assert.AreEqual(13983816, GetCombinations(49, 6));
        }


        double GetFactorial(int number)
        {
            double result = 1; 
            for(int i = 1; i <= number;i++)
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

        double GetProbability(int numberofExtractions, int category,  int numberofFailedExtractions, int numberofPosibilities)
        {
            double probability = 0;

            int partial = 0;

            partial += numberofExtractions - numberofFailedExtractions;

            probability = probability + (GetCombinations(numberofExtractions, numberofFailedExtractions) * GetCombinations(partial, (numberofPosibilities - numberofExtractions))) / GetCombinations(numberofExtractions, numberofPosibilities);

            return probability;

        }

    }
}
