using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Question_no_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;

            Console.WriteLine("Enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * radius * radius;
            Console.WriteLine("Area of the circle is " + area);
            Console.ReadKey();
        }
    }
}
