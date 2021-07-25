//Author: PRAVEEN U K
//Exercise: Annual Salary
//Date: 24/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee ID");
            string empId = Console.ReadLine();
            Console.WriteLine("Enter Basic Pay");
            double basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Special Allowance");
            double splAllow = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Percentage of Bonus");
            double perOfBonus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Tax Saved Monthly");
            double taxSavMnthly = Convert.ToDouble(Console.ReadLine());

            double grossAnnual, netAnnual, taxPaid=1, mnthlyGross, bonus, taxableIncome=0;

            mnthlyGross = basic + splAllow;
            bonus = (basic * 12) * perOfBonus / 100.0;
            grossAnnual = mnthlyGross * 12 + bonus;

            if (grossAnnual > 100000)
            {
                if (taxSavMnthly <= 100000)
                {
                     taxableIncome = grossAnnual - taxSavMnthly;
                }
                else
                {
                    taxableIncome = grossAnnual - 100000;
                }
            }
            if (taxableIncome > 250000)
            {
                taxPaid = 25000 + (taxableIncome - 250000) * 0.3;
            }
            else if(taxableIncome>150000)
            {
                taxPaid = 5000 + (taxableIncome - 150000) * 0.2;
            }
            else if (taxableIncome > 100000)
            {
                taxPaid = (taxableIncome - 100000) * 0.1;
            }

            netAnnual = grossAnnual - taxPaid;

            Console.WriteLine($"Gross Annual = {grossAnnual}\nNet Annual = {netAnnual}\nTax Paid= {taxPaid}");
            Console.ReadLine();

           
        }
    }
}
