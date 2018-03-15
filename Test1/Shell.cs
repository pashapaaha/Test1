using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Shell
    {
        public static void sort(int[] arr)
        {
            int arrayLength = arr.Length;
            int step = stepCalculation(arrayLength);

            while (step > 0)
            {
                for (int i = step; i < arrayLength; i++)
                    sortingInterval(arr, step, i);
                step /= 2;
            }
        }

        private static int stepCalculation(int arrayLength)
        {
            int step = (int)(Math.Log(arrayLength) / Math.Log(2)) - 1;
            int h = 1;
            for (int i = 0; i < step; i++)
                h = h * 2 + 1;
            return h;
        }

        private static void shifts(int[] array, int step, ref int index)
        {
            array[index + step] = array[index];
            index -= step;
        }

        private static void sortingInterval(int[] array, int step, int index)
        {
            int a = array[index];
            int j = index - step;
            while (j >= 0 && array[j] > a)
                shifts(array, step, ref j);
            array[j + step] = a;
        }
    }
}
