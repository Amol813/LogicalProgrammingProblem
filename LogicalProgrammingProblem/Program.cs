using LogicalProgrammingPracticeProblem;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Logical Programming Practice Problem!");
        bool flag = true;
        while (flag)
        {
            Console.Write("1. Fibonacci\n2. Exit\nEnter your option to execute: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fib = new FibonacciSeries();
                    Console.Write("Enter the number of Fibonacci Series: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    fib.PrintFibonacciSeries(num);
                    break;
                case 2:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
