using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 6, 7, 8, 9, 12 };
            int[] a2 = new int[] { 7, 9, 12 };

            int[] b = DifferenceOfTwoSets(a1, a1.Length, a2, a2.Length);

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            Console.ReadKey();
        }

        /*
            1. Create b empty array, size is N1
            2. 0-N1 & 0-N2
            3. If the a1's actual item is lower than a2's actual item, then
               - Increase the counter
               - Copy the actual values into b from a1
               - Stepping...
            4. If the a1's actual item is bigger than a2's actual item, then
               - Stepping...
            5. Else
               -Stepping with both indexer
            6. While i is lower than N1
               - Increase the counter
               - Copy the actual values into b from a1
               - Stepping
            7. Returns the difference of two sets
        */

        #region Difference of two sets
        static int[] DifferenceOfTwoSets(int[] a1, int n1, int[] a2, int n2)
        {
            int[] b = new int[n1]; //1.
            int i = 0;
            int j = 0;
            int counter = 0;
            while ((i < n1) && (j < n2)) //2.
            {
                if (a1[i] < a2[j]) //3.
                {
                    counter++;
                    b[counter] = a1[i];
                    i++;
                }
                else if (a1[i] > a2[j]) //4.
                {
                    j++;
                }
                else //5.
                {
                    i++;
                    j++;
                }
            }
            while (i < n1) //6.
            {
                counter++;
                b[counter] = a1[i];
                i++;
            }
            return b; //7.
        }
        #endregion
    }
}