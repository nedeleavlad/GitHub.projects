using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pascal_s_triangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Row3()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, GetPascalTriangle(3));
        }

        public int[] GetPascalTriangle(int row)
        {
            int[] result = new int[row];
            if (row == 1)
            {
                return new int[] { 1 };
            }
            result[0] = 1;

            result[row - 1] = 1;

            int[] previous = GetPascalTriangle(row - 1);

            for (int i = 1; i < row - 1; i++)
            {
                result[i] = previous[i - 1] + previous[i];
            }

            return result;
        }
    }
}