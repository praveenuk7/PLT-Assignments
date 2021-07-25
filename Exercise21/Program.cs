//Author: PRAVEEN U K
//Exercise: Reverse a string
//Date: 24/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            string rev = new string(str.Reverse().ToArray());
            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
}
