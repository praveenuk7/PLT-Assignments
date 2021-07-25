//Author: PRAVEEN U K
//Exercise: Swap 2 Variables
//Date: 23/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        public void swapWithThirdVar()
        {
            Console.WriteLine("Swap Using Third Variable\n");

            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers before Swapping\nnum1 = {num1}\nnum2 = {num2}\n");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"Numbers after Swapping\nnum1 = {num1}\nnum2 = {num2}\n");
        }

        public void swapWithoutThirdVar()
        {
            Console.WriteLine("Swap Without Using Third Variable\n");

            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers before Swapping\nnum1 = {num1}\nnum2 = {num2}\n");

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine($"Numbers after Swapping\nnum1 = {num1}\nnum2 = {num2}\n");

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.swapWithThirdVar();
            obj.swapWithoutThirdVar();
            Console.Read();
        }
    }
}
