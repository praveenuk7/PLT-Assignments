//Author: PRAVEEN U K
//Exercise: Patterns Question 25
//Date: 25/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25
{
    class Program
    {
        public void FirstPattern()
        {
            int i, j, n, a = 1, sign = 1;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for ( i = 1; i <=n; i++)
            {
                for ( j = 1; j <=i; j++)
                {
                    Console.Write(a*a*sign+" ");
                    a++;
                    sign = -sign;

                }
                Console.WriteLine();
            }
        }
        public void SecondPattern()
        {
            int i, j, n, a = 1, b=0;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(a+" ");
                    b = b + 1;
                    a = a * b;                
                }
                Console.WriteLine();
            }
        }
        public void ThirdPattern()
        {
            int i, j, n;
            Console.WriteLine("Enter N");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <=n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j>=n+1-i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                      
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
                for (j = 1; j <= n+4; j++)
                {
                    if (j >= n + 1 - i && j<=n-1+i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.FirstPattern();
            Console.WriteLine();

            obj.SecondPattern();
            Console.WriteLine();

            obj.ThirdPattern();
            Console.WriteLine();

            obj.FourthPattern();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
