using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool l = IsASubsetOfB(a, a.Length - 1, b, b.Length - 1); //-1 to avoid indexing problems

            Console.WriteLine(l);

            Console.ReadKey();
        }

        /*
            1. While a's actual value is bigger than b's actual value
            2. If a's actual value is equals with b's actual value
               - Stepping...
            3. Returns true, if a is subset of b
        */

        #region Is a subset of b?
        static bool IsASubsetOfB(int[] a, int m, int[] b, int n)
        {
            int i = 0;
            int j = 0;
            while ((i <= m) && (j <= n) && (a[i] >= b[j])) //1.
            {
                if (a[i] == b[j]) //2.
                    i++;
                j++;
            }
            //3.
            bool l = (i > m);
            return l;
        }
        #endregion
    }
}