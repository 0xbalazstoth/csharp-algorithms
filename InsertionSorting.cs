using System;

namespace Csharp_Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 43, 12, 2, 3 };
            InsertionSorting(ref x, x.Length);

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            Console.ReadKey();
        }

        #region Insertion sorting
        /*
            1. Sorting by reference
               Before sorting the length of the array is one, then two, in the end it will work with full length
            2. Examine the neighbours
            3. Swapping
            4. The nth element must also be inserted in place, while the (n - 1) element is already arranged
        */

        private static void InsertionSorting(ref int[] x, int n) //1.
        {
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                while ((j >= 0) && (x[j] > x[j + 1])) //2.
                {
                    int swap = x[j]; //3.
                    x[j] = x[j + 1];
                    x[j + 1] = swap;
                    j--; //4.
                }
            }
        }
        #endregion
    }
}
