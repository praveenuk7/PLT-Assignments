//Author: PRAVEEN U K
//Exercise: Binary Search
//Date: 25/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise27
{
    class Program
    {
        static int BinarySearch(int[] arr, int l,
                            int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return BinarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter how many elements to store in array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[5];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int l = arr.Length;
            int x;
            Console.WriteLine("Enter Search Element");
            x = Convert.ToInt32(Console.ReadLine());

            int result = BinarySearch(arr, 0, l - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
            Console.ReadLine();
        }
    }
}
