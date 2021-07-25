//Author: PRAVEEN U K
//Exercise: Largest and Second Largest of 3 Numbers
//Date: 23/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int large, secLarge;

            if (num1 > num2)
            {
                large = num1;
                secLarge = num2;
            }
            else
            {
                large = num2;
                secLarge = num1;
            }
            if (num3 > large)
            {
                secLarge = large;
                large = num3;
            }
            else if(num3 >secLarge)
            {
                secLarge = num3;
            }

            Console.WriteLine($"Large is {large}\nSecond Large is {secLarge}");

            Console.ReadLine();
        }
    }
}
