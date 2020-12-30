using System;

namespace Csharp_Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 2020, 2021, 123, 5411243, -112, 2 };
            MinimalSelectionSort(ref x, x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            Console.ReadKey();
        }

        #region Minimum selection sorting
        /*
            1. Sorting by reference
            2. Select the smallest item's index.
            3. Compare the actual value with the smallest item.
            4. Swapping
        */

        private static void MinimalSelectionSort(ref int[] x, int n) //1.
        {
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (x[min] > x[j]) //3.
                    {
                        min = j; //2
                    }
                }
                int swap = x[i]; //4.
                x[i] = x[min];
                x[min] = swap;
            }
        }
        #endregion
    }
}
