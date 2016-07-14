using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        #region Fibonacci
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        #endregion

        #region QuickSort
        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }


#endregion
static void Main(string[] args)
        {
    #region Fibonacci
    //Console.WriteLine("input integer number:");
    //int n = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Your Fibonacci Series:");
    //for (int i = 0; i < n; i++)
    //{
    //    Console.Write(Fibonacci(i) + " ");
    //}
    #endregion

    #region QuickSort
    // Create an unsorted array of string elements
            string[] unsorted = { "z","e","x","c","m","q","a"};
 
            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
 
            Console.WriteLine();
 
            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);
 
            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
 
            Console.WriteLine();
 
            Console.ReadLine();
    #endregion
    Console.ReadKey();
           
        }
    }
}
