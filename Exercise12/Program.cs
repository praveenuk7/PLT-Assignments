//Author: PRAVEEN U K
//Exercise: Five Patterns Question 12
//Date: 26/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void pattern4_16_36_N(int n)
        {
            int i = 2;

            while (i * i <= n)
            {
                Console.WriteLine(i * i);
                i = i + 2;
            }
        }

        static void pattern1_neg2_3_neg4_N(int n)
        {
            int i = 1;
            n = Math.Abs(n);

            while (i <= n)
            {
                if (i % 2 == 0)
                    Console.WriteLine(-i);
                else
                    Console.WriteLine(i);
                i = i + 1;
            }
        }
        static void pattern_1_4_27_256_N(int n)
        {
            int i = 1;
            while (Math.Pow(i, i) <= n)
            {
                Console.WriteLine(Math.Pow(i, i));
                i = i + 1;
            }

        }
        static void pattern_1_4_7_12_N(int n)
        {
            int i = 1, j = 4, k = 7, next = 0;
            if (n >= 7)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
                Console.WriteLine(k);
            }
            else if (n >= 4)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);

            }
            else if (n >= 1)
            {
                Console.WriteLine(i);
            }

            next = i + j + k;
            while (next <= n)
            {
                Console.WriteLine(next);
                i = j;
                j = k;
                k = next;

                next = i + j + k;
            }
        }
        static void pattern_1_4_9_25_N(int n)
        {
            int i = 1;

            while ((i * i) <= n)
            {
                if (i % 4 != 0)
                    Console.WriteLine(i * i);
                i = i + 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\nThe pattern is\n");
            pattern4_16_36_N(n);
            pattern1_neg2_3_neg4_N(n);
            pattern_1_4_7_12_N(n);
            pattern_1_4_27_256_N(n);
            pattern_1_4_9_25_N(n);
            Console.ReadLine();
        }
    }
}
