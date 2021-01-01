using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 3, 5, 8 };
            int index = Selection(x, x.Length - 1); //-1 to avoid indexing problems

            Console.WriteLine(index);

            Console.ReadKey();
        }

        #region Selection
        /*
            1. While the first item is not odd.
            2. Return the item's index.
        */

        static int Selection(int[] x, int n)
        {
            int i = 0;
            while (!(x[i] % 2 == 0)) //1.
            {
                i++;
            }
            int index = i;
            return index; //2.
        }
        #endregion
    }
}