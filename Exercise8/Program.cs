using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double totHrs, ratePerHr, consHrs = 0, consRatePerHr = 0, hwInfraCosts = 0,
                swLicCosts = 0, projCost, swCost = 0, profits;
            char hasExternalConsultants, hasHwInfra, hasSoftwareLic, freqType = 'N';

            Console.WriteLine("Enter the total hours ");
            totHrs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate per hour ");
            ratePerHr = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Do you have an external consultant?\n1.Type Y for yes\n2.Type any other chracter for no");
            hasExternalConsultants = Convert.ToChar(Console.ReadLine());
            if (hasExternalConsultants == 'y' || hasExternalConsultants == 'Y')
            {
                Console.WriteLine("Enter the consultation hours ");
                consHrs = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the consultant rate per hour ");
                consRatePerHr = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Does the project need Hardware purchaess?\n1.Type Y for yes\n2.Type any other chracter for no");
            hasHwInfra = Convert.ToChar(Console.ReadLine());
            if (hasHwInfra == 'y' || hasHwInfra == 'Y')
            {
                Console.WriteLine("Enter the Hardware purchase cost ");
                hwInfraCosts = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Does the project need Software licenses purchases?\n1.Type Y for yes\n2.Type any other chracter for no");
            hasSoftwareLic = Convert.ToChar(Console.ReadLine());
            if (hasSoftwareLic == 'y' || hasSoftwareLic == 'Y')
            {
                Console.WriteLine("Enter the Software licenses purchase cost ");
                swLicCosts = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Mention the frequency of Software licenses purchases?\n1.Type C for common\n2.Type R for rare");
                freqType = Convert.ToChar(Console.ReadLine());
            }

            projCost = totHrs * ratePerHr;
            projCost = projCost + (hwInfraCosts) * 0.3;

            if (freqType == 'C' || freqType == 'c')
                swCost = swLicCosts * 0.5;
            else if (freqType == 'R' || freqType == 'r')
                swCost = swLicCosts;

            projCost = projCost + swCost;
            Console.WriteLine($"The cost of the project is {projCost}");

            profits = projCost - ((consHrs * consRatePerHr) + (hwInfraCosts) + (swLicCosts));
            Console.WriteLine($"The profit obtained from the project is {profits}");

            if (profits > 0)
                Console.WriteLine("\nThe project is profitable");
            else
                Console.WriteLine("\nThe project incurs a loss");

            Console.ReadLine();



        }
    }
}
