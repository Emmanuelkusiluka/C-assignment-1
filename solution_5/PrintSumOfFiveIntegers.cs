// Condition:Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.

namespace PrintSumOfFiveIntegers
{
    class program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,e;
            Console.Write("Enter first number: ");
            bool isaInt = int.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter second number: ");
            bool isbInt = int.TryParse(Console.ReadLine(), out b);

            Console.Write("Enter third number: ");
            bool iscInt = int.TryParse(Console.ReadLine(), out c);

            Console.Write("Enter fourth number: ");
            bool isdInt = int.TryParse(Console.ReadLine(), out d);

            Console.Write("Enter fifth number: ");
            bool iseInt = int.TryParse(Console.ReadLine(), out e);

            if (isaInt & isbInt & iscInt & isdInt & iseInt)
            {
                Console.WriteLine("The sum of all five numbers = {0}", a+b+c+d+e);
            }
            else
            {
                Console.WriteLine("Enter valid integer numbers! ");
            }
        }
    }
}




