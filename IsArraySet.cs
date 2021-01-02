using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 45, 65, 678, 2 };
            bool l = IsArraySet(x, x.Length - 1);

            Console.WriteLine(l);

            Console.ReadKey();
        }

        /*
            1. While actual item and the neighbour is equal
            2. Returns with true or false
        */

        #region Is array set?
        static bool IsArraySet(int[] x, int n)
        {
            int i = 1;
            while (i <= n && x[i] != x[i - 1]) //1.
            {
                i++;
            }
            //2.
            bool l = i > n;
            return l;
        }
        #endregion
    }
}