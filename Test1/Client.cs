using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Client
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 53, 4, 3, 41, 56, 45, 68, 15, 46, 64, 5, 6, 8, 51, 33, 54 };
            printArray(array);
            Shell.sort(array);
            printArray(array);
            Console.ReadKey();
        }

        static void printArray(int[] arr)
        {
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
