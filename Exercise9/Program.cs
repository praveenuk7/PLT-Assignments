//Author: PRAVEEN U K
//Exercise: Sum of Odd Numbers
//Date: 24/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n, sum=0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                sum = sum + i;
                i = i + 2;
            }
            Console.WriteLine($"Sum = {sum}");
            Console.ReadLine();

        }
    }
}
