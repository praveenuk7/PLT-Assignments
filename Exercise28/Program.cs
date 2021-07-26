//Author: PRAVEEN U K
//Exercise: Transpose Matrix4
//Date: 26/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[100, 100];
            int m, n;
            Console.WriteLine("Enter the number of rows of the matrix :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns of the matrix :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Enter the element {i}{j}");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix you entered");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
            }

            Console.WriteLine("\nThe transpose of the matrix");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[j, i]}\t");
                }
            }
            Console.Read();
        }
    }
}
