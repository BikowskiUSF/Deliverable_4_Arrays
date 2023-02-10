using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare an array to store our Fibonacci numbers
            int[] fibonacciNumbers = new int[25];

            // set the first two numbers in the sequence
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;

            // use a loop to calculate the rest of the numbers
            for (int i = 2; i < fibonacciNumbers.Length; i++)
            {
                // The next number in the sequence is just the sum of the previous two
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            // print each number in the sequence to the console
            for (int i = 0; i < fibonacciNumbers.Length; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacciNumbers[i]);
            }

            // pause the console to see the output
            Console.ReadLine();
        }
    }
}
