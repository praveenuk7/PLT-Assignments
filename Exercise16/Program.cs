//Author: PRAVEEN U K
//Exercise: Binary to Decimal
//Date: 24/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            int bin, i=0, rem;
            double dec = 0;
            Console.WriteLine("Enter Binary number");
            bin = Convert.ToInt32(Console.ReadLine());

            while (bin!=0)
            {
                rem = bin % 10;
                bin = bin / 10;
                dec += rem * Math.Pow(2, i);
                ++i;
            }
            Console.WriteLine($"Decimal Equivalent is {dec}");
            Console.ReadLine();
        }
    }
}
