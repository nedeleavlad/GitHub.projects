using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rent_penalty
{
    [TestClass]
    public class Rent
    {
        [TestMethod]
        public void rentPenalty10()
        {

            Assert.AreEqual(11, calculateRent(10,10);
        };


        [TestMethod]
        public void rentPenalty30()
        {

            Assert.AreEqual(15, calculateRent(10,25));
        }

        [TestMethod]
        public void rentPenalty40()
        {

            Assert.AreEqual(45, calculateRent(10,35));
        }

         double calculateRent(double rent, int noPenaltyDays)

        {
            if ((1 <= noPenaltyDays) && (noPenaltyDays <= 10) return (rent + noPenaltyDays * 0.01*rent);
            if ((11 <= noPenaltyDays) && (noPenaltyDays <= 30)   return (rent + noPenaltyDays * 0.02*rent);
            if ((30 <= noPenaltyDays) && (noPenaltyDays <= 40) return (rent + noPenaltyDays * 0.1*rent);
        }





    }
    




    


               

    





}
