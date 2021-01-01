using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 6, 2, 8 };
            bool mDetermination = ModifiedDetermination(x, x.Length - 1); //-1 to avoid indexing problems

            Console.WriteLine(mDetermination);

            Console.ReadKey();
        }

        #region Modified determination
        /*
            1. While not every item is not even.
            2. If every time is even, return true.
        */

        static bool ModifiedDetermination(int[] x, int n)
        {
            int i = 0;
            while ((i <= n) && x[i] % 2 == 0) //1.
            {
                i++;
            }
            bool found = (i > n);
            return found;
        }
        #endregion
    }
}
