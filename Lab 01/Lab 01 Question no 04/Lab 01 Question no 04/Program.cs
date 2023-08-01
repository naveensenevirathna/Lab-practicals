using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Question_no_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary;
            double taxRate;
            double salaryAfterTax;

            Console.WriteLine("Enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the tax rate: ");
            taxRate = Convert.ToDouble(Console.ReadLine());

            salaryAfterTax = salary - (salary * taxRate);

            Console.WriteLine("The salary after tax is " + salaryAfterTax);
            Console.ReadKey();
        }
    }
}
