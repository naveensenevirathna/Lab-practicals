using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string evenOrOdd;

            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2==0)
            {
                evenOrOdd = "even";
            }
            else
            {
                evenOrOdd = "odd";
            }
            Console.WriteLine("The number is " + evenOrOdd);
            Console.ReadKey();
        }
    }
}
