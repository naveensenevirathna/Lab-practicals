using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Question_no_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            string[] evenOrOdd = new string[10];

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0;i<10;i++)
            {
                if (numbers[i] % 2==0)
                {
                    evenOrOdd[i] = "even";
                }
                else
                {
                    evenOrOdd[i] = "odd";
                }
                for (int i = 0; i < 10; i++;)
                {
                Console.WriteLine("The number is ", i + 1, evenOrOdd[i]);
            }
            Console.ReadKey();
            }
        }
    }
}
