using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Question_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int vowelCount = 0;

            Console.WriteLine("Enter a string: ");
            str = Console.ReadLine();

            string vowels = "aeiouAEIOU";
            for (int i = 0; i < str.Length; i++) 
            {
                if (vowels.Contains(str[i]))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("The number of vowels in the string is " + vowelCount);
            Console.ReadKey();
        }
    }
}
