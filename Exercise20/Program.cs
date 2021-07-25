//Author: PRAVEEN U K
//Exercise: Power
//Date: 24/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, i, power=1;
            Console.WriteLine("Enter x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n");
            n = Convert.ToInt32(Console.ReadLine());

            if(x==0 && n == 0)
            {
                Console.WriteLine("Not Possible");
            }
            else
            {
                for ( i = 1; i <= n; i++)
                {
                    power = power * x;
                }
            }
            Console.WriteLine($"{x} to the power {n} is {power}");
            Console.ReadLine();
        }
    }
}
