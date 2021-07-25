//Author: PRAVEEN U K
//Exercise: Four Patterns Question 23
//Date: 25/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23
{
    class Program
    {
        public void FirstPattern()
        {
            int i, j, n;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for ( i = 1; i <= n; i++)
            {
                for ( j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void SecondPattern()
        {
            int i, j, n;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public void ThirdPattern()
        {
            int i, j, n;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public void FourthPattern()
        {
            int i, j, n;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.FirstPattern();
            //obj.SecondPattern();
            //obj.ThirdPattern();
            obj.FourthPattern();
            Console.ReadLine();
        }
    }
}
