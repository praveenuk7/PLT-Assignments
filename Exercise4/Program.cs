//Author: PRAVEEN U K
//Exercise: Fractional and Whole Part
//Date: 24/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter double value");
            double value = Convert.ToDouble(Console.ReadLine());
            double fractionalPart = value % 1;
            double wholePart = value - fractionalPart;
            Console.WriteLine($"Original Value = {value}");
            Console.WriteLine($"Whole Part = {wholePart}");
            Console.WriteLine($"Fractional Part = {fractionalPart}");
            Console.ReadLine();
            
        }
    }
}
