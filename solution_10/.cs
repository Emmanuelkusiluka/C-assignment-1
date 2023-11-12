// condition:Write a program that reads from the console a positive integer number
// N (N < 20) and prints a matrix of numbers as on the figures below:
// N = 3 N = 4
// {1 2 3
// 2 3 4
// 3 4 5}
// {1 2 3 4
// 2 3 4 5
// 3 4 5 6
// 4 5 6 7}

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number N (N < 20): ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < i + n; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
