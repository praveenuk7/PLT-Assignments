//Author: PRAVEEN U K
//Exercise: Symmetric Matrix
//Date: 26/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[100, 100];
            int m;
            int i = 0, j = 0;
            Console.WriteLine("Enter the size of the matrix :");
            m = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine($"Enter the element {i}{j}");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix you entered");
            for (i = 0; i < m; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
            }
            bool symmetric = true;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if ((i == j && arr[i, j] == 0) || (i != j && arr[i, j] != arr[j, i]))
                    {
                        symmetric = false;
                        break;
                    }
                }
            }
            if (symmetric == true)
                Console.WriteLine("\nThe Matrix entered is a symmetric matrix");
            else
                Console.WriteLine("\nThe Matrix entered is not a symmetric matrix");
            Console.Read();
        }
    }
}
