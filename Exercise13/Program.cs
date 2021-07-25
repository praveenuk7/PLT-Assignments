//Author: PRAVEEN U K
//Exercise: Sum of Prime
//Date: 25/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, sum=0;
            bool isPrime = true;
            Console.WriteLine("Enter n and m");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                n++;
            }
            while (n <= m)
            {
                isPrime = true;
                i = 3;
                while (i<=Math.Sqrt(n) && (isPrime==true))
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                    }
                    i++;
                }
                if (isPrime == true)
                {
                    Console.WriteLine(n);
                    sum = sum + n;
                }
                n = n + 2;
            }
            Console.Read();
        }
    }
}
