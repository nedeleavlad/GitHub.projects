using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace cube_end888
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(192, FindCube(1));

            Assert.AreEqual(0, FindCube(0));
        }

        int FindCube(int number)
        {
            int contor = 0;
            int a=0;
            if (number == 0) return 0;

            for(int i=0;i<30000;i++)
            {
                if (EndCube888(i) == true)
                {

                    a = i;
                    contor++;
                    if (contor == number) break;

                }

            }
            return a; 


        }


        bool EndCube888(int number)
        {
            double cube = Math.Pow(number, 3);
            
            if(cube>888)
            {
                cube = cube % 1000;



            }

            if (cube == 888)
                return true;
            else return false;
           
        }



    }
}
