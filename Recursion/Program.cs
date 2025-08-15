using System.Runtime.InteropServices;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //printArray(5);
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(sum(arr.ToList()));
            Console.WriteLine(maxNum(arr.ToList()));
            Console.ReadKey();
        }

        /// <summary>
        /// Prints numbers from n down to 0 recursively, separated by spaces.
        /// </summary>
        /// <param name="n">The starting integer to print from.</param>
        public static void printArray(int n)
        {
            Console.Write(n + " ");
            if (n <= 0)
                return;
            else
                printArray(n - 1);
        }

        /// <summary>
        /// Calculates the factorial of a given integer recursively.
        /// </summary>
        /// <param name="n">The integer to calculate the factorial of. Must be greater than 0.</param>
        /// <returns>The factorial of the input integer.</returns>
        public static int fact(int n)
        {
            if (n == 1)
                return n;
            else
                return n * fact(n - 1);
        }

        /// <summary>
        /// Recursively calculates the sum of all elements in a list of integers.
        /// </summary>
        /// <param name="list">The list of integers to sum.</param>
        /// <returns>The sum of all integers in the list.</returns>
        public static int sum(List<int> list)
        {
            int index = 0;
            int n = list.Count;
            if (index == n)
                return 0;
            else
                return n + sum(list[++index..]);
        }

        /// <summary>
        /// Recursively finds the maximum value in a list of integers.
        /// </summary>
        /// <param name="list">The list of integers to search.</param>
        /// <returns>The maximum integer in the list.</returns>
        public static int maxNum(List<int> list)
        {
            if (list.Count == 1)
            {
                return list[0];
            }
            else
                return Math.Max(list[0], maxNum(list[1..]));
        }
    }
}
