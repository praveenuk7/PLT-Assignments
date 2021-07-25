//Author: PRAVEEN U K
//Exercise: Question 17
//Date: 25/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 7, count = 1;
            Console.WriteLine("The multiples of 7 with remainder 1 when divided by 2,3,4,5 and 6 are\n");
            while (count <= 4)
            {
                if ((i % 2 == 1) && (i % 3 == 1) && (i % 4 == 1) && (i % 5 == 1) && (i % 6 == 1))
                {
                    if (count != 3)
                        Console.WriteLine($"\nThe multiple number {count} is {i}");
                    count = count + 1;
                }
                i = i + 7;
            }
            Console.ReadLine();
        }
    }
}
