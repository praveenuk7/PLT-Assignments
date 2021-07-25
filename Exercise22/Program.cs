//Author: PRAVEEN U K
//Exercise: Pallindrome
//Date: 24/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
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
            if(str == rev)
            {
                Console.WriteLine("Pallindrome");
            }
            else
            {
                Console.WriteLine("Not a Pallindrome");
            }
            Console.ReadLine();
        }
    }
}
