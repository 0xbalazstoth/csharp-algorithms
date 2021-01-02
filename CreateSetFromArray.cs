using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 23, 23, 5, 6, 1, 1, 2 };
            int[] y = CreateSetFromArray(x, x.Length);

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
            }

            Console.ReadKey();
        }

        /*
            1. Create y empty array, size n
            2. 0-N
            3. If x's actual item is not in y, then
               - Increase counter and copy the actual item to y
            4. Return with y set
        */

        #region Create set from array
        static int[] CreateSetFromArray(int[] x, int n)
        {
            int[] y = new int[n]; //1.
            int counter = 0;
            for (int i = 0; i < n; i++) //2.
            {
                if (x[i] != y[counter]) //3.
                {
                    counter++;
                    y[counter] = x[i];
                }
            }
            return y; //4.
        }
        #endregion
    }
}