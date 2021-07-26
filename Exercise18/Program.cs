//Author: PRAVEEN U K
//Exercise: Billing System
//Date: 26/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemCode, desc;
            int qty = 0;
            double price, granTot = 0;
            char modeofPayment = 'R';
            char choice = 'y';
            while (choice == 'Y' || choice == 'y')
            {
                Console.WriteLine("Enter the Item Code: ");
                itemCode = Console.ReadLine();
                Console.WriteLine("Enter the description: ");
                desc = Console.ReadLine();
                Console.WriteLine("Enter the quantity: ");
                qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price of item: ");
                price = Convert.ToInt32(Console.ReadLine());
                granTot = granTot + (qty * price);
                Console.WriteLine("Enter your choice: \n To include more items enter-Y \n If not enter any key\n ");
                choice = Convert.ToChar(Console.ReadLine());


            }
            Console.WriteLine("Enter the mode of Payment: \n To pay via card, enter-R\n To pay via cash, enter-C\n");
            modeofPayment = Convert.ToChar(Console.ReadLine());
            if (granTot > 10000)
            {
                granTot = (granTot * 0.9);
            }


            else if (granTot < 1000 && modeofPayment == 'R' || modeofPayment == 'r')
            {
                granTot = granTot + (granTot * 0.025);

            }
            else if (granTot < 1000 && modeofPayment == 'C' || modeofPayment == 'c')
            {

            }

            Console.WriteLine($"Grand Total= {granTot}");
            Console.Read();
        }

    }
}
