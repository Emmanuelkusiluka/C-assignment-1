// Condition: Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.


namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}






