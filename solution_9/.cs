// Condition:9.	Write a C# program from the code below
//  	 Determine if a number is prime
// Console.Write("Enter a positive number: ");
// int num = int.Parse(Console.ReadLine());
// int divider = 2;
// int maxDivider = (int)Math.Sqrt(num);
// bool prime = true;
// while (prime && (divider <= maxDivider))
// {
// if (num % divider == 0)
// {
// prime = false;
// }
// divider++;
// }
// Console.WriteLine("Prime? " + prime);


using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (num % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? " + prime);
        }
    }
}