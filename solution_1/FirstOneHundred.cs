// Condition: Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8

namespace PrintFirstOneHundred
{
    class FirstOneHundred
    {
        static void Main (string[] args)
        {
            for (int i = 2; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
                else
                {
                    Console.Write("{0} ", -i);
                }
            }

            Console.WriteLine();
        }
    }
}


// extra solutions 

using System;

class Program
{
    static void Main()
    {
        int row = 1;

        do
        {
            int col = 1;
            do
            {
                Console.Write($"{row * col}\t");
                col++;
            } while (col <= 12);

            Console.WriteLine(); // Move to the next row after printing each row
            row++;

        } while (row <= 10);
    }
}

