using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1071;
            int n = 462;
            int gcd = Euclidean(m, n);
            Console.WriteLine(gcd);

            Console.ReadKey();
        }

        #region Euclidean

        /*
            GCD = Greatest Common Divisor
            Algorithm: 
                      1. Two integers, m and n, m is bigger.
                      2. Divide m with n, the remainder is r.
                      3. If r is 0, so m is divisible with n, then the algorithm is ended. The GCD is equals with n, the algorithm is ended.
                      4. If r is not 0, then copy n's actual value to m and copy r's value to n. Then jump to the second step.
        */

        static int Euclidean(int m, int n) //1.
        {
            int r = m % n; //2.

            //3.
            while (r != 0) 
            {
                //4.
                m = n;
                n = r;
                r = m % n;
            }
            return n;
        }
        #endregion
    }
}
