using System;

namespace LogicalProgrammingPracticeProblem
{
    public class FibonacciSeries
    {
        public void PrintFibonacciSeries(int num)
        {
            int firstNum = 0, secondNum = 1, fibonacciValue;
            Console.Write(firstNum + " " + secondNum + " ");
            for (int i = 2; i < num; i++)
            {
                fibonacciValue = firstNum + secondNum;
                Console.Write(fibonacciValue + " ");
                firstNum = secondNum;
                secondNum = fibonacciValue;
            }
            Console.WriteLine();
        }
    }
}
