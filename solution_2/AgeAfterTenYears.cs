// Condition: Write a program that reads your age from the console and prints your age after 10 years.

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your current age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be: " + (age + 10));
=======
            Console.Write("Input your current age: ");           

            /*ToInt32 is used to convert input interger which is taken as a string to interger
             so as to perform an arthmetic operation*/
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your age after 10 years: ");

            age += 10 ;

            Console.Write("{0} ", age);

        }
    }
}