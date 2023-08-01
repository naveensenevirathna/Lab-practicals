using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Question_no_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int sum;
            int subtraction;
            int multiplication;
            float division;

            Console.WriteLine("Enter your first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            sum = firstNumber + secondNumber;
            subtraction = firstNumber - secondNumber;
            multiplication = firstNumber * secondNumber;
            division = (float)firstNumber / secondNumber;

            Console.WriteLine("The sum of the two numbers is " + sum);
            Console.WriteLine("The substraction of the two numbers is " + subtraction);
            Console.WriteLine("The multiplication of the two numbers is " + multiplication);
            Console.WriteLine("The division of the two numbers is " + division);
            Console.ReadKey();
        }
    }
}
