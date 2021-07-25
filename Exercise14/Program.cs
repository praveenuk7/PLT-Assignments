//Author: PRAVEEN U K
//Exercise: Factorial
//Date: 25/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fact = 1;
            Console.WriteLine("Enter Number");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Not Possible");
            }
            else
            {
                while (n >= 2)
                {
                    fact = fact * n;
                    n = n - 1;
                }
            }
            Console.WriteLine($"Fact ={fact}");
            Console.ReadLine();
        }
    }
}
