using System;

namespace FibonacciRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++){
                Console.WriteLine(Fibonacci(i));
            }
        }

        private static int Fibonacci(int length){
            if (length == 0 || length == 1)
            {
                return length;
            }

            else
            {
                return Fibonacci(length - 1) + Fibonacci(length - 2);    
            }
        }
    }
}
