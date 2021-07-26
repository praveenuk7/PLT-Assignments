//Author: PRAVEEN U K
//Exercise: Identity Matrix
//Date: 26/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise29
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
            bool identity = true;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if ((i == j && arr[i, j] != 1) || (i != j && arr[i, j] != 0))
                    {
                        identity = false;
                        break;
                    }
                }
            }
            if (identity == true)
                Console.WriteLine("\nThe Matrix entered is an identity matrix");
            else
                Console.WriteLine("\nThe Matrix entered is not an identity matrix");
            Console.Read();
        }
    }
}
