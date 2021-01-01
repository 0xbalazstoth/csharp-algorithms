using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 15, 20, 1 };
            int sum = SumElements(x, x.Length);

            Console.WriteLine(sum);

            Console.ReadKey();
        }

        #region Sum Elements Of Array
        /*
            1. Create a start variable to store the sum of values.
            2. 0-N
            3. Sum the values
            4. Return the result
        */

        static int SumElements(int[] x, int n)
        {
            int startValue = 0;
            for (int i = 0; i < n; i++)
            {
                startValue += x[i];
            }
            int sum = startValue;
            return sum;
        }
        #endregion
    }
}