//Author: PRAVEEN U K
//Exercise: Student Marks
//Date: 23/07/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name of Student");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Marks in subject1");
            int score1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks in subject2");
            int score2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks in subject3");
            int score3 = Convert.ToInt32(Console.ReadLine());

            double average = (score1 + score3 + score3) / 3.0;

            if(score1>=35 && score2>=35 && score3 >= 35)
            {
                if (average >= 60)
                {
                    Console.WriteLine("First Class");
                }
                else if (average >= 50)
                {
                    Console.WriteLine("Second Class");
                }
                else
                {
                    Console.WriteLine("Pass Class");
                }
            }
            else
            {
                Console.WriteLine("Student Failed");
            }
            Console.ReadLine();

        }
    }
}
