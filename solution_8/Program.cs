 // respect brother
 ﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace QuadraticEquation

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coefficient a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coefficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coefficient c: ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equation has one real root: " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The equation has two real roots: " + x1 + " and " + x2);
            }
        }
    }
}
