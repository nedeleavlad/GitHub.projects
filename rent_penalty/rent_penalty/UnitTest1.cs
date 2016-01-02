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

            Assert.AreEqual(11, rentValue(10, 10));
        }


        [TestMethod]
        public void rentPenalty30()
        {

            Assert.AreEqual(15, rentValue(10,25));
        }

        [TestMethod]
        public void rentPenalty40()
        {

            Assert.AreEqual(45, rentValue(10,35));
        }

     double  rentValue (double rent, int noPenaltyDays)

        {
            if ((1 <= noPenaltyDays) && (noPenaltyDays <= 10)) return (rent + noPenaltyDays * 0.01 * rent);

           

                     else if ((11 <= noPenaltyDays) && (noPenaltyDays <= 30)) return (rent + noPenaltyDays * 0.02 * rent);


                                  else  return (rent + noPenaltyDays * 0.1 * rent);

            
        }





    }
    




    


               

    





}
