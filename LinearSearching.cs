using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 9, 11, 2 };
            int index = LinearSearching(x, x.Length - 1); //-1 to avoid indexing problems

            Console.WriteLine(index);

            Console.ReadKey();
        }

        #region Linear Searching
        /*
            1. Start from the leftmost element of x[] and one by one compare value with each element of x[]
            2. If x matches with an element, return the index.
            3. Else, return -1. 
        */

        static int LinearSearching(int[] x, int n)
        {
            int i = 0;
            while ((i <= n) && !(x[i] % 2 == 0)) //1.
            {
                i++;
            }
            bool found = (i <= n);
            if (found)
            {
                //2.
                int index = i;
                return index;
            }
            else
            {
                //3.
                return -1;
            }
        }
        #endregion
    }
}