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
            var n0 = 0;
            var n1 = 1;
            int n;

            for (var i = 0; i < length; i++)
            {
                Console.WriteLine(n0);
                n = n1 + n0;
                n0 = n1;
                n1 = n;
            }
        }
    }
}
