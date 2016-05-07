using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TowersofHanoi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Number_of_Moves()
        {
            Assert.AreEqual(7, GetNumberOfMoves(3));
        }

        [TestMethod]
        public void NoMovesforOneDisk()
        {
            Assert.AreEqual(1, GetNumberOfMoves(1));
        }

        public int GetNumberOfMoves(int numberOfDisks)
        {
            if (numberOfDisks == 1) return 1;

            return (2 * GetNumberOfMoves(numberOfDisks - 1)) + 1;
        }
    }
}