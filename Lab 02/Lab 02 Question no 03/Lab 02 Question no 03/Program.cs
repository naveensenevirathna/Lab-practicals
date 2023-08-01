using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Question_no_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            double circumference;

            Console.WriteLine("Enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * radius * radius;
            circumference = 2 * radius * Math.PI;

            Console.WriteLine("Area of the circle is " + area);
            Console.WriteLine("Circumference of the circle is " + circumference);
            Console.ReadKey();
        }
    }
}
