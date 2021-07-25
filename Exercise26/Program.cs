//Author: PRAVEEN U K
//Exercise: Linear Search
//Date: 25/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26
{
    class Program
    {
        public static int LinearSearch(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
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
            int x;
            Console.WriteLine("Enter Search Element");
            x = Convert.ToInt32(Console.ReadLine());

           
            int result = LinearSearch(arr, x);
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index "
                                  + result);
            Console.Read();
        }
    }
}
