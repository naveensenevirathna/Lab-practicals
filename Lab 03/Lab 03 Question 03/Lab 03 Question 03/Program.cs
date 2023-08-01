using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Question_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; number > 0; i++)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }
            Console.WriteLine("The sum of the digits is " + sum);
            Console.ReadKey();

        }
    }
}
