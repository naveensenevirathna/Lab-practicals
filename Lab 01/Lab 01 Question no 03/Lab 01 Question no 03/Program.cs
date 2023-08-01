using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Question_no_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int sum;

            Console.WriteLine("Enter your first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            sum = firstNumber + secondNumber;
            Console.WriteLine("The sum of the two numbers is " + sum);
            Console.ReadKey();
        }
    }
}
