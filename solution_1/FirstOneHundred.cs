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



// second question 
using System;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public double CalculateBonus(double salesPercentage)
    {
        if (salesPercentage > 0)
        {
            return 0.15 * Salary; // apa 15% bonus
        }
        else
        {
            return 0; //Other wise no bonus
        }
    }
}


class Program
{
    static void Main()
    {
        //creating new instance of Employee class for Juma
        Employee juma = new Employee("Juma", 50000);

        // Juma's sales percentage
        double salesPercentage = 0.6; // 60%

        // Calculate and add the bonus
        double bonus = juma.CalculateBonus(salesPercentage);
        double totalSalary = juma.Salary + bonus;

        Console.WriteLine($"{juma.Name}'s salary: {juma.Salary} TSH");
        Console.WriteLine($"{juma.Name}'s bonus: {bonus} TSH");
        Console.WriteLine($"Total salary with bonus: {totalSalary} TSH");
    }
}

 
