using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 27, 35 };
            bool[] y = RelativePrime(x, x.Length, 6);
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine($"{x[i]} {y[i]}");
            }

            Console.ReadKey();
        }

        #region Relative prime examination

        /*
            Each prime number is relatively prime to everything else, and for a prime number,
                all natural numbers are less than the relative prime number.
            For a given prime number, any natural number is a relative prime that is not a multiple of.
            1 is a relative prime for all integers. 0 only applies to 1 and ‒1.
            Even two consecutive natural numbers are always relatively primary to each other.
            The fact that two numbers are relatively prime is done using the Euclidean algorithm. 
        */
        static bool[] RelativePrime(int[] x, int n, int value)
        {
            bool[] y = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if (Euclidean(x[i], value) == 1)
                    y[i] = true;
                else
                    y[i] = false;
            }
            return y;
        }

        /*----------------------------------------------------------------------------------------------------------------------------------*/

        /*
            GCD = Greatest Common Divisor
            Algorithm: 
                      1. Two integers, m and n, m is bigger.
                      2. Divide m with n, the remainder is r.
                      3. If r is 0, so m is divisible with n, then the algorithm is ended. The GCD is equals with n, the algorithm is ended.
                      4. If r is not 0, then copy n's actual value to m and copy r's value to n. Then jump to the second step. 
        */
        static int Euclidean(int m, int n)
        {
            int r = m % n;
            while (r != 0)
            {
                m = n;
                n = r;
                r = m % n;
            }
            return n;
        }
        #endregion
    }
}