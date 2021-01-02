using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 45, 234, 5678, 14344 };
            bool l = IsSetContainsGivenValue(x, x.Length - 1, 56718); //-1 to avoid indexing problems

            Console.WriteLine(l);

            Console.ReadKey();
        }

        /*
            1. Create a variable named left, this is the lower limit
            2. Create a variable named right, this is the upper limit
            3. Select the set's center item
            4. While the center item is not equal to the given number
               - If the center item is bigger than the given number, it will be in the first part of the set
               - If the center item is not bigger than the given number, it will be in the second part of the set
            5. Returns true, if the given value is in the set
        */

        #region Is set contains given value?
        static bool IsSetContainsGivenValue(int[] x, int n, int givenValue)
        {
            int left = 0; //1.
            int right = n; //2.
            int center = (left + right) / 2; //3.
            while ((left <= right) && (x[center] != givenValue)) //4.
            {
                if (x[center] > givenValue)
                {
                    right = center - 1;
                }
                else
                {
                    left = center + 1;
                }
                center = (left + right) / 2;
            }
            bool l = (left <= right);
            return l;
        }
        #endregion
    }
}