using System;

namespace Csharp_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 45, 27, 1, 2 };
            int[] a2 = new int[] { -1, 76, 1, 2 };
            int[] b = UnionOfSets(a1, a1.Length - 1, a2, a2.Length - 1); //-1 to avoid indexing problems

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            Console.ReadKey();
        }

        /*
            1. Create b empty array, size is N1 + N2
            2. 0-N1
               - Copy a1's items into b
            3. 0-N2
               - 0-N1 and while a2's actual item is not equals to a1's actual item
                 a) Stepping...
               - If i is bigger than N1, then
                 a) Copy a2's actual item into b
                 b) Stepping...
            4. Returns with union of sets
        */

        #region Union of sets
        static int[] UnionOfSets(int[] a1, int n1, int[] a2, int n2)
        {
            int[] b = new int[n1 + n2]; //1.
            int i = 0;
            int j = 0;
            int k = 0;
            n1 = a1.Length;
            n2 = a2.Length;
            for (i = 0; i < n1; i++) //2.
            {
                b[i] = a1[i];
            }
            k = n1;
            for (j = 0; j < n2; j++) //3.
            {
                i = 0;
                while ((i < n1) && (a2[j] != a1[i]))
                {
                    i++;
                }
                if (i >= n1)
                {
                    b[k] = a2[j];
                    k++;
                }
            }
            return b;
        }
        #endregion
    }
}