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
            int[] arr2 = { 5, 2, 6, 9, 8 };
            //Console.WriteLine(sum(arr.ToList()));
            //Console.WriteLine(maxNum(arr.ToList()));
            //Console.WriteLine(binarySearch(arr.ToList(), 6, 0, arr.Length - 1));
            //Console.WriteLine(quickSort(arr2.ToList()));
            foreach (int i in quickSort(arr2.ToList()))
            {
                Console.Write(i + " ");
            }
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

        /// <summary>
        /// Recursively performs a binary search on a sorted list of integers to find the index of a specified key.
        /// </summary>
        /// <param name="arr">The sorted list of integers to search.</param>
        /// <param name="key">The integer value to search for.</param>
        /// <param name="left">The starting index of the search range.</param>
        /// <param name="right">The ending index of the search range.</param>
        /// <returns>
        /// The index of the key in the list if found; otherwise, <c>null</c>.
        /// </returns>
        public static int? binarySearch(List<int> arr, int key, int left, int right)
        {
            if (left > right)
                return null;
            int mid = (left + right) / 2;
            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                return binarySearch(arr, key, mid + 1, right);
            else
                return binarySearch(arr, key, left, mid - 1);
        }

        /// <summary>
        /// Recursively sorts a list of integers using the QuickSort algorithm.
        /// </summary>
        /// <param name="arr">The list of integers to sort.</param>
        /// <returns>
        /// A new list containing the sorted integers in ascending order.
        /// </returns>
        public static List<int> quickSort(List<int> arr)
        {
            if (arr.Count < 2)
                return arr;
            int pivot = arr[0];
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 1; i < arr.Count; i++) // Start from index 1 to skip the pivot
            {
                if (arr[i] < pivot)
                    left.Add(arr[i]);
                else
                    right.Add(arr[i]);
            }
            // Concatenate the sorted left, pivot, and sorted right
            return quickSort(left).Concat(new List<int> { pivot }).Concat(quickSort(right)).ToList();
        }
    }
}
