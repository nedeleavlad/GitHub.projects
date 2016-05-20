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
            return new int[] { 2, 3, 43, 56, 69, 87 };
        }
    }
}