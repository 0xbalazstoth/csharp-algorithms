using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 3, 9};
            int count = Count(x, x.Length);

            Console.WriteLine(count);

            Console.ReadKey();
        }

        #region Count
        /*
            1. Create a start variable to store the counted items. 
            2. 0-N
            3. If the actual item is even, then
               - Increase the count
            4. Return with the counted items.
        */

        static int Count(int[] x, int n)
        {
            int count = 0; //1.
            for (int i = 0; i < n; i++) //2.
            {
                if (x[i] % 2 == 0) //3.
                {
                    count++;
                }
            }
            return count; //4.
        }
        #endregion
    }
}