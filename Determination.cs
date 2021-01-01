using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 3, 7, 9, 2};
            bool found = Determination(x, x.Length - 1); //-1 to avoid indexing problems

            Console.WriteLine(found);

            Console.ReadKey();
        }

        #region Determination

        /*
            1. While item is not even
            2. Return true, if found
        */

        static bool Determination(int[] x, int n)
        {
            int i = 0;
            while ((i <= n) && !(x[i] % 2 == 0)) //1.
            {
                i++;
            }
            bool found = (i <= n);
            return found; //2.
        }
        #endregion
    }
}