//Author: PRAVEEN U K
//Exercise: Simple Interest
//Date: 23/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double principleAmount, timePeriod, rateOfInterest, simpleInterest;

            Console.WriteLine("Enter Principle Amount");
            principleAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time Period");
            timePeriod = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate of Interest");
            rateOfInterest = Convert.ToDouble(Console.ReadLine());

            simpleInterest = (principleAmount * timePeriod * rateOfInterest) / 100;

            Console.WriteLine($"Simple Interest Calculated for {timePeriod} years is {simpleInterest}");

            Console.ReadLine();
        }
    }
}
