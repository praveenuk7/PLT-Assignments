//Author: PRAVEEN U K
//Exercise: Pattern Question 19
//Date: 26/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class Program
    {
        public void PatternOne()
        {
            int limit, sign = 1, num = 1;
            Console.Write("Enter the number of elements needed in the series:");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                Console.Write(num * sign + ",");
                num += (i * i);
                sign *= -1;
            }
        }
        public void PatternTwo()
        {
            int limit, a, b = 1, next = 1;
            Console.Write("Enter the number of elements needed in the series:");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                Console.Write(next + ",");
                a = b;
                b = next;
                next = a + b;
            }
        }
        public void PatternThree()
        {
            int limit, a = 1, b = -2;
            Console.WriteLine("Enter the number of elements needed in the series(Greater than 2 and even):");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < limit / 2; i++)
            {
                Console.Write($"{a},{b},");
                a += 3;
                b -= 4;
            }
        }
        public void PatternFour()
        {
            int limit, a = 1, b = 5, c = 8, next;
            next = a + b + c;
            Console.WriteLine("Enter the number of elements needed in the series( greater than 3):");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{a},{b},{c},");
            for (int i = 3; i < limit; i++)
            {
                Console.Write(next + ",");
                a = b;
                b = c;
                c = next;
                next = a + b + c;

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Question 19");
            int option;
            Console.WriteLine("<===Menu===>");
            Console.WriteLine("1.Pattern 1");
            Console.WriteLine("2.Pattern 2");
            Console.WriteLine("3.Pattern 3");
            Console.WriteLine("3.Pattern 4");

            Console.WriteLine("Enter an option.");
            option = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            switch (option)
            {
                case 1:
                    obj.PatternOne();
                    break;
                case 2:
                    obj.PatternTwo();
                    break;
                case 3:
                    obj.PatternThree();
                    break;
                case 4:
                    obj.PatternFour();
                    break;

            }
            Console.ReadLine();
        }

    }
}
