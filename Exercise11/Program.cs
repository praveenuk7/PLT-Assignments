//Author: PRAVEEN U K
//Exercise: Question 11
//Date: 25/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit, num, rev = 0;

            String[] stringarr = new String[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            bool nonZeroFound = false;
            int trailingZero = 0, i;
            Console.WriteLine("Enter the number ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                digit = num % 10;
                if (nonZeroFound == false)
                    if (digit != 0)
                        nonZeroFound = true;
                    else
                        trailingZero = trailingZero + 1;
                rev = rev * 10 + digit;
                num = num / 10;
            }


            while (rev > 0)
            {

                Console.WriteLine(stringarr[(rev % 10)]);
                rev = rev / 10;

            }
            i = 1;
            while (i <= trailingZero)
            {
                Console.WriteLine("Zero");
                i = i + 1;
            }
            Console.ReadLine();
        }
    }
}
