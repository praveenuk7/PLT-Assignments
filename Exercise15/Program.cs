//Author: PRAVEEN U K
//Exercise: Decimal to Binary
//Date: 24/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec, rem;
            double bin=0;
            int i=0;
            Console.WriteLine("Enter Decimal number");
            dec = Convert.ToInt32(Console.ReadLine());

            while (dec >= 1)
            {
                bin = bin + (dec % 2) * Math.Pow(10, i);
                dec = dec / 2;
                i = i + 1;
            }
            Console.WriteLine($"Binary Equivalent is {bin}");
            Console.ReadLine();
        }
    }
}
