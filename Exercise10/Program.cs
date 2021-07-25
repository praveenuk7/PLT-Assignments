//Author: PRAVEEN U K
//Exercise: Reverse of Number
//Date: 24/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit, num, rev = 0;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            Console.WriteLine($"Reversed Number = {rev}");
            Console.ReadLine();
        }
    }
}
