//Author: PRAVEEN U K
//Exercise: Four Patterns Question 24
//Date: 25/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    class Program
    {
        public void FirstPattern()
        {
            int i, j, n;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
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
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
        public void ThirdPattern()
        {
            int i, j, n, k=1;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(k+" ");
                    k++;
                }
                Console.WriteLine();
            }
        }
        public void FourthPattern()
        {
            int i, j, n, a=1, b=0, next=1;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(next+" ");
                    a = b;
                    b = next;
                    next = a + b;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.FirstPattern();
            obj.SecondPattern();
            obj.ThirdPattern();
            obj.FourthPattern();
            Console.Read();

        }
    }
}
