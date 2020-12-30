using System;

namespace Csharp_Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 2, 6, -1, 34 };
            BubbleSort(ref x, x.Length);

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            Console.ReadKey();
        }

        #region Bubblesort
        /*
            1. Sorting by reference
            2. In first, examine the neighbours
               - (n - 1) & n items
               - The biggest item is going to the end. (It rises like a bubble)
            3. In second, examine the neighbours till (n - 1)
               - (n - 2) & (n - 1)
            4. Swapping
        */

        private static void BubbleSort(ref int[] x, int n) //1.
        {
            for (int i = 0; i <= n - 2; i++) //2.
            {
                for (int j = 0; j <= n - 2; j++) //3.
                {
                    if (x[i] > x[j + 1])
                    {
                        int swap = x[j]; //4
                        x[j] = x[j + 1];
                        x[j + 1] = swap;
                    }
                }
            }
        }
        #endregion
    }
}
