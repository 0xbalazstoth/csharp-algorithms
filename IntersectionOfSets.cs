using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 5, 8, 9, 11 };
            int[] a2 = new int[] { 8, 9, 12, 30};
            int[] b = IntersectionOfSets(a1, a1.Length - 1, a2, a2.Length - 1); //-1 to avoid indexing problems

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            Console.ReadKey();
        }

        /*
            1. Create b empty array, size is Min(N1, N2)
            2. 0-N1 & 0-N2
            3. If the a1's actual item is lower than a2's actual item, then
               - Stepping...
            4. If the a1's actual item is bigger than a2's actual item, then
               - Stepping...
            5. Else
               - Increase the counter
               - Copy the actual values into b from a1
            6. Returns with the intersection of sets
        */

        #region Intersection of sets
        static int[] IntersectionOfSets(int[] a1, int n1, int[] a2, int n2)
        {
            //1.
            int min = Math.Min(n1, n2);
            int[] b = new int[min];
            int i = 0;
            int j = 0;
            int counter = 0;
            while ((i <= n1) && (j <= n2)) //2.
            {
                if (a1[i] < a2[j]) //3.
                {
                    i++;
                }
                else if (a1[i] > a2[j]) //4.
                {
                    j++;
                }
                else //5.
                {
                    counter++;
                    b[counter] = a1[i];
                    i++;
                    j++;
                }
            }
            return b; //6.
        }
        #endregion
    }
}