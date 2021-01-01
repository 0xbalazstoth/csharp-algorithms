using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 4, 12, 2534, 9999 };
            int max = Maximumselection(x, x.Length);

            Console.WriteLine(max);

            Console.ReadKey();
        }

        #region Maximumselection
        /*
            1. The first item of the array is the "biggest".
            2. Create a max variable to store the biggest number.
            3. 0-N
            4. If the actual number is bigger, then then before
               - That is the biggest number
            5. Return the biggest number.
        */

        static int Maximumselection(int[] x, int n)
        {
            //x[0] = 1.
            int max = 0; //2.
            for (int i = 0; i < n; i++) //3.
            {
                if (max < x[i]) //4.
                {
                    max = x[i];
                }
            }
            return max; //5.
        }
        #endregion
    }
}