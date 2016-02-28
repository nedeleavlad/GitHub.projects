using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace loto_649
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateProbability2()
        {
            Assert.AreEqual(1.84498995124078E-05, GetProbability(49, 6, 5),1E-5);
        }
        [TestMethod]
        public void CalculateCombinations()
        {
            Assert.AreEqual(13983816, GetCombinations(49, 6));
        }
        [TestMethod]
        public void CalculateProbability1()
        {
            Assert.AreEqual(7.15112384201852E-08, GetProbability(49, 6, 6),1E-5);
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

        double GetCombinations(int number, int howMany)
        {
            double result = (GetFactorial(number) / (GetFactorial(howMany) * GetFactorial(number - howMany)));

            return result;
        }


        double GetProbability(int numberoftheBalls, int noBallsSingleTicket, int noBallsWinningTicket)
        {
            double probability = +((GetCombinations(noBallsSingleTicket, noBallsWinningTicket) * GetCombinations(numberoftheBalls - noBallsSingleTicket, noBallsSingleTicket - noBallsWinningTicket)) / GetCombinations(numberoftheBalls, noBallsSingleTicket));

            return probability;
        }


    }

}

