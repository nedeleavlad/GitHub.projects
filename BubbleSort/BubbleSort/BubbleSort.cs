using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class BubbleSort
    {
        private int[] givenArray;

        public BubbleSort(int[] givenArray)
        {
            this.givenArray = givenArray;
        }

        public int[] ShowBubbleSortMethod(int[] givenArray)
        {
            int j;
            bool flag = true;
            int temp;

            while (flag)
            {
                flag = false;
                for (j = 0; j < givenArray.Length - 1; j++)
                {
                    if (givenArray[j] > givenArray[j + 1])
                    {
                        temp = givenArray[j];
                        givenArray[j] = givenArray[j + 1];
                        givenArray[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            return givenArray;
        }
    }
}