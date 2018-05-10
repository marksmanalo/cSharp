using System;

// Output the Fibonacci sequence non recursively
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintFibonacci(10);
        }

        private static void PrintFibonacci(int length)
        {
            var prevResult = 0;
            var currentResult = 0;
            for (var i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    currentResult = 0;
                }
                if (i == 1)
                {
                    currentResult = 1;    
                }
                else
                {
                    var result = currentResult + prevResult;
                    prevResult = currentResult;
                    currentResult = result;
                }

                Console.WriteLine(currentResult);
            }
        }
    }
}
