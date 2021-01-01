using System;

namespace Csharp_Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 5, -10, 523, 27};
            Quicksort(ref x, 0, x.Length - 1); // -1 to avoid indexing problems

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            Console.ReadKey();
        }

        /*
            Divide and conquer approach:
                1. Divide the problem into a number of subproblems that are smaller instances of the same problem.
                2. Conquer the subproblems by solving them recursively. If they are small enough, solve the subproblems as base cases.
                3. Combine the solutions to the subproblems into the solution for the original problem.
        */

        #region Quicksort
        /*
            1.  Separate the elements of the array x to be sorted so that elements with a smaller value than
                the first element are in front of the first element and larger ones are behind it.
            2.  The reference element is certain to have reached its final location at the end of the sort.
            3.  Perform this sorting for the smaller than the fulcrum element and for the larger ones separately.
        */

        private static void Quicksort(ref int[] x, int left, int right)
        {
            int index = Partition(ref x, left, right);

            //3.
            if (index > left + 1)
            {
                Quicksort(ref x, left, index - 1);
            }
            if (index < right)
            {
                Quicksort(ref x, index + 1, right);
            }
        }

        private static int Partition(ref int[] x, int left, int right) //1.
        {
            int temp = x[left];
            while (left < right)
            {
                while ((left < right) && (x[right] > temp))
                {
                    right--;
                }
                if (left < right)
                {
                    x[left] = x[right];
                    left++;
                    while ((left < right) && (x[left] <= temp))
                    {
                        left++;
                    }
                    if (left < right)
                    {
                        x[right] = x[left];
                        right--;
                    }
                }
            }
            //2.
            int index = left;
            x[index] = temp;
            return index;
        }
        #endregion
    }
}
