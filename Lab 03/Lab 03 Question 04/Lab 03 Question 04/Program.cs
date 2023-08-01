using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            int oddNumber;

            Console.WriteLine("Enter a positive integer: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (oddNumber=1; oddNumber<=number; oddNumber=oddNumber+1)
            {
                sum += oddNumber;
            }
            Console.WriteLine("The sum of the odd numbers is " + sum);
            Console.ReadKey();
        }
    }
}
